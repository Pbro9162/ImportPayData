using ExcelDataReader;
using Microsoft.Data.SqlClient;
using System.Data;
using Z.BulkOperations.Internal.InformationSchema;


namespace ImportPayData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTableCollection tableCollection;

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilename.Text = openFileDialog.FileName;

                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {

                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });

                            tableCollection = result.Tables;
                            cboSheet.Items.Clear();

                            foreach (DataTable table in tableCollection)
                            {

                                cboSheet.Items.Add(table.TableName); // add sheet to combobox
                            }
                        }
                    }
                }
            }
        }



        private void CboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-SUAB0U9;Database=10009;User ID=Tester;Password=password1234;TrustServerCertificate=True;";
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];



            if (dt != null)
            {
                //GET BATCHID, UNIQUE FOR EACH IMPORT
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand c = new SqlCommand("SELECT dbo.ufn_GET_IMPORTBATCH_ID(@param)", connection);
                    int id = 99998; // Default value, change to take user input later.

                    c.Parameters.AddWithValue("@param", id);
                    string batchIDresult = c.ExecuteScalar().ToString();


                    //UPDATES DATA TABLE WITH BATCHID
                    foreach (DataRow row in dt.Rows)
                    {
                        row["cImportBatchID"] = batchIDresult; // Edit the "cimportbatchid" column for this row


                    }
                    dataGridView1.Refresh();


                    // Create a list to hold the PRTransactionMaster objects
                    List<PRTransactionMaster> t = new List<PRTransactionMaster>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        PRTransactionMaster tr = new PRTransactionMaster();

                        tr.IDGLCompany = Convert.ToInt32(dt.Rows[i]["Company ID"]);
                        tr.CGLCompanyID = dt.Rows[i]["cGLCompanyID"].ToString();
                        tr.IDPREEmployee = Convert.ToInt32(dt.Rows[i]["Employee ID"]);
                        tr.CCheckNumber = dt.Rows[i]["Check Number"].ToString();
                        tr.DCheckDate = Convert.ToDateTime(dt.Rows[i]["Check Date"]);
                        tr.DAccountingDate = Convert.ToDateTime(dt.Rows[i]["Accounting Date"]);
                        tr.DPayPeriodStart = Convert.ToDateTime(dt.Rows[i]["Pay Period Start"]);
                        tr.DPayPeriodEnd = Convert.ToDateTime(dt.Rows[i]["Pay Period End"]);
                        tr.NGrossAmount = Convert.ToDecimal(dt.Rows[i]["Gross Amount"]);
                        tr.NNetAmount = Convert.ToDecimal(dt.Rows[i]["Net Amount"]);
                        tr.NRegularPay = Convert.ToDecimal(dt.Rows[i]["Regular Pay"]);
                        tr.NOvertimePay = Convert.ToDecimal(dt.Rows[i]["Overtime Pay"]);
                        tr.NTimeOffPay = Convert.ToDecimal(dt.Rows[i]["Time Off Pay"]);
                        tr.NRegularHours = Convert.ToDecimal(dt.Rows[i]["Regular Hours"]);
                        tr.NOvertimeHours = Convert.ToDecimal(dt.Rows[i]["Overtime Hours"]);
                        tr.NTimeOffHours = Convert.ToDecimal(dt.Rows[i]["Time Off Hours"]);
                        tr.NDoNotPayHours = Convert.ToDecimal(dt.Rows[i]["Do Not Pay Hours"]);
                        tr.BPRModule = false; // Assuming this is a boolean, adjust as necessary
                        tr.CImportBatchID = batchIDresult;
                        // Add the transaction to the list
                        t.Add(tr);
                    }

                    pRTransactionMasterBindingSource.DataSource = t;
                    dataGridView1.DataSource = pRTransactionMasterBindingSource;
                }
            }
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            List<PRTransactionMaster> transactions = pRTransactionMasterBindingSource.DataSource as List<PRTransactionMaster>;

            switch (e.ColumnIndex)
            {
                case 0:
                    // Handle changes in the "Company ID" column
                    if (transactions != null && e.RowIndex >= 0 && e.RowIndex < transactions.Count)
                    {
                        transactions[e.RowIndex].IDGLCompany = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                        MessageBox.Show(transactions[e.RowIndex].IDGLCompany.ToString());
                    }
                    break;
                case 1:
                    // Handle changes in the "cGLCompanyID" column
                    if (transactions != null && e.RowIndex >= 0 && e.RowIndex < transactions.Count)
                    {
                        transactions[e.RowIndex].CGLCompanyID = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    }
                    break;
            }
            pRTransactionMasterBindingSource.DataSource = transactions; // Update the binding source with the modified list
            pRTransactionMasterBindingSource.ResetBindings(false); // Refresh the DataGridView to reflect changes



        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=DESKTOP-SUAB0U9;Database=10009;User ID=Tester;Password=password1234;TrustServerCertificate=True;"; // Replace with your actual connection string
 
                List<PRTransactionMaster> transactions = pRTransactionMasterBindingSource.DataSource as List<PRTransactionMaster>;
                if (transactions != null)
                {


                    using (SqlBulkCopy bk = new SqlBulkCopy(connectionString))
                    {
                        
                        DataTable dt = transactions.ToDataTable(); // Convert the list to a DataTable
                        

                        bk.BulkCopyTimeout = 600;
                        bk.DestinationTableName = "dbo.PRTRANSACTIONMASTER";

                        bk.ColumnMappings.Add("IDGLCompany", "idGLCompany");
                        bk.ColumnMappings.Add("cGLCompanyID", "cGLCompanyID");
                        bk.ColumnMappings.Add("IDPREEmployee", "idPREmployee");
                        bk.ColumnMappings.Add("CCheckNumber", "cCheckNumber");
                        bk.ColumnMappings.Add("DCheckDate", "dCheckDate");
                        bk.ColumnMappings.Add("DAccountingDate", "dAccountingDate");
                        bk.ColumnMappings.Add("DPayPeriodStart", "dPayPeriodStart");
                        bk.ColumnMappings.Add("DPayPeriodEnd", "dPayPeriodEnd");
                        bk.ColumnMappings.Add("NGrossAmount", "nGrossAmount");
                        bk.ColumnMappings.Add("NNetAmount", "nNetAmount");
                        bk.ColumnMappings.Add("NRegularPay", "nRegularPay");
                        bk.ColumnMappings.Add("NOvertimePay", "nOvertimePay");
                        bk.ColumnMappings.Add("NTimeOffPay", "nTimeOffPay");
                        bk.ColumnMappings.Add("NRegularHours", "nRegularHours");
                        bk.ColumnMappings.Add("NOvertimeHours", "nOvertimeHours");
                        bk.ColumnMappings.Add("NTimeOffHours", "nTimeOffHours");
                        bk.ColumnMappings.Add("NDoNotPayHours", "nDoNotPayHours");
                        bk.ColumnMappings.Add("CImportBatchID", "cImportBatchID");

                        bk.WriteToServer(dt.CreateDataReader());
                    }
                }
                MessageBox.Show("FINISHED");

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during import: " + ex.Message, "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

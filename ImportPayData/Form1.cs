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
            dataGridView1.DataError += DataGridView1_DataError;
        }

        private void DataGridView1_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            // Suppress the default error dialog
            e.ThrowException = false;

            // Access error details
            Exception ex = e.Exception;
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            DataGridViewDataErrorContexts context = e.Context;

            // Customize the error message or display your own dialog
            string errorMessage = $"Data error in cell ({rowIndex}, {columnIndex}): {ex.Message} Please enter a valid input before importing or exiting.";

            // Option 1: Display a custom MessageBox
            MessageBox.Show(errorMessage, "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // Option 2: Set an error icon and text for the specific cell or row
            // dataGridView1.Rows[rowIndex].Cells[columnIndex].ErrorText = "Invalid value entered.";
            // dataGridView1.Rows[rowIndex].ErrorText = "Error in this row.";

            // Option 3: Log the error without displaying a dialog
            // Console.WriteLine(errorMessage);
        }

        DataTableCollection tableCollection;
        string fileName;

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                //fetch file path and file name, import to  [dbo].[ZZUTILITYLOG] table 

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    //FILENAME
                    fileName = Path.GetFileName(openFileDialog.FileName);
                    MessageBox.Show("Selected File: " + fileName);


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

                    //UPDATE BATCHID TEXTBOX ITEM
                    batchid_txt.Text = batchIDresult;

                    //UPDATES DATA TABLE WITH BATCHID (May not be necessary)
                    //foreach (DataRow row in dt.Rows)
                    //{
                    //   row["cImportBatchID"] = batchIDresult; // Edit the "cimportbatchid" column for this row


                    //  }
                    dataGridView1.Refresh();


                    // Create a list to hold the PRTransactionMaster objects
                    List<PRTransactionMaster> t = new List<PRTransactionMaster>();
                    
                    // Create a list to hold the Totals objects
                    List<Totals> totalsList = new List<Totals>();

                    //Create a List to hold/Display batch ID
                    List<PRTransactionMaster> batchIDList = new List<PRTransactionMaster>();
                    PRTransactionMaster b = new PRTransactionMaster();
                    b.CImportBatchID = batchIDresult;
                    batchIDList.Add(b); // Add the batch ID object to the list

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        PRTransactionMaster tr = new PRTransactionMaster();

                        tr.IDGLCompany = Convert.ToInt32(dt.Rows[i]["Company ID"]);
                        tr.CGLCompanyID = dt.Rows[i]["cGLCompanyID"].ToString();
                        tr.IDPREEmployee = Convert.ToInt32(dt.Rows[i]["Employee ID"]);
                        tr.CEmployeeName = dt.Rows[i]["Employee Name"].ToString();
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
                    // Calculate totals by iterating through the list t and summing the values 
                    Totals tl = new Totals
                    {
                        grossTotal = t.Sum(x => x.NGrossAmount),
                        netTotal = t.Sum(x => x.NNetAmount),
                        regularPayTotal = t.Sum(x => x.NRegularPay),
                        overtimePayTotal = t.Sum(x => x.NOvertimePay),
                        timeOffPayTotal = t.Sum(x => x.NTimeOffPay),
                        regularHoursTotal = t.Sum(x => x.NRegularHours),
                        overtimeHoursTotal = t.Sum(x => x.NOvertimeHours),
                        timeOffHoursTotal = t.Sum(x => x.NTimeOffHours),
                        doNotPayHoursTotal = t.Sum(x => x.NDoNotPayHours)
                    };
                    // Add the totals to the list
                    totalsList.Add(tl);


                    pRTransactionMasterBindingSource.DataSource = t;
                    dataGridView1.DataSource = pRTransactionMasterBindingSource;
                    dataGridView2.DataSource = totalsList; // Bind the totals list to the second DataGridView
                    
                }
            }
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Validate indices
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var transactions = pRTransactionMasterBindingSource.DataSource as List<PRTransactionMaster>;
            if (transactions == null || e.RowIndex >= transactions.Count) return;

            object cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            // Map grid column index -> PRTransactionMaster property name
            var columnMap = new Dictionary<int, string>
            {
                [0]  = nameof(PRTransactionMaster.IDGLCompany),
                [1]  = nameof(PRTransactionMaster.CGLCompanyID),
                [2]  = nameof(PRTransactionMaster.IDPREEmployee),
                [3]  = nameof(PRTransactionMaster.CEmployeeName),
                [4]  = nameof(PRTransactionMaster.CCheckNumber),
                [5]  = nameof(PRTransactionMaster.DCheckDate),
                [6]  = nameof(PRTransactionMaster.DAccountingDate),
                [7]  = nameof(PRTransactionMaster.DPayPeriodStart),
                [8]  = nameof(PRTransactionMaster.DPayPeriodEnd),
                [9]  = nameof(PRTransactionMaster.NGrossAmount),
                [10] = nameof(PRTransactionMaster.NNetAmount),
                [11] = nameof(PRTransactionMaster.NRegularPay),
                [12] = nameof(PRTransactionMaster.NOvertimePay),
                [13] = nameof(PRTransactionMaster.NTimeOffPay),
                [14] = nameof(PRTransactionMaster.NRegularHours),
                [15] = nameof(PRTransactionMaster.NOvertimeHours),
                [16] = nameof(PRTransactionMaster.NTimeOffHours),
                [17] = nameof(PRTransactionMaster.NDoNotPayHours)
            };

            if (!columnMap.TryGetValue(e.ColumnIndex, out var propName)) return;

            var prop = typeof(PRTransactionMaster).GetProperty(propName);
            if (prop == null) return;

            // Convert cell value to property's target type
            object convertedValue;
            if (cellValue == null || cellValue == DBNull.Value || string.IsNullOrWhiteSpace(cellValue?.ToString()))
            {
                // For non-nullable value types use default(T), for reference/nullable types use null
                var t = prop.PropertyType;
                convertedValue = (t.IsValueType && Nullable.GetUnderlyingType(t) == null) ? Activator.CreateInstance(t) : null;
            }
            else
            {
                var targetType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                try
                {
                    if (targetType == typeof(string)) convertedValue = cellValue.ToString();
                    else if (targetType == typeof(DateTime)) convertedValue = Convert.ToDateTime(cellValue);
                    else if (targetType == typeof(int)) convertedValue = Convert.ToInt32(cellValue);
                    else if (targetType == typeof(decimal)) convertedValue = Convert.ToDecimal(cellValue);
                    else if (targetType == typeof(bool)) convertedValue = Convert.ToBoolean(cellValue);
                    else convertedValue = Convert.ChangeType(cellValue, targetType);
                }
                catch
                {
                    // Invalid conversion — TELL USER TO ENTER CORRECT VALUE TYPE
                    MessageBox.Show($"Invalid value for {propName}. Please enter a value of type {targetType.Name}.");
                    return;
                }
            }
            //UPDATE TOTALS AFTER CELL VALUE CHANGE
            Totals tl = new Totals
            {
                grossTotal = transactions.Sum(x => x.NGrossAmount),
                netTotal = transactions.Sum(x => x.NNetAmount),
                regularPayTotal = transactions.Sum(x => x.NRegularPay),
                overtimePayTotal = transactions.Sum(x => x.NOvertimePay),
                timeOffPayTotal = transactions.Sum(x => x.NTimeOffPay),
                regularHoursTotal = transactions.Sum(x => x.NRegularHours),
                overtimeHoursTotal = transactions.Sum(x => x.NOvertimeHours),
                timeOffHoursTotal = transactions.Sum(x => x.NTimeOffHours),
                doNotPayHoursTotal = transactions.Sum(x => x.NDoNotPayHours)
            };
            dataGridView2.DataSource = new List<Totals> { tl };

            // Apply change and refresh bindings
            prop.SetValue(transactions[e.RowIndex], convertedValue);
            pRTransactionMasterBindingSource.ResetBindings(false);
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            //TO-DO: INCLUDE HANDLING FOR DUPLICATE ENTRIES BASED ON BATCH ID OR OTHER UNIQUE FIELDS
            //IF DUPLICATES FOUND, PROMPT USER TO OVERWRITE OR SKIP IMPORT OF DUPLICATES
            //* CHECK IF BATCH TO BE IMPORTED IS BLANK BEFOREHAND
            try
            {
                string connectionString = "Server=DESKTOP-SUAB0U9;Database=10009;User ID=Tester;Password=password1234;TrustServerCertificate=True;"; // Replace with your actual connection string

                List<PRTransactionMaster> transactions = pRTransactionMasterBindingSource.DataSource as List<PRTransactionMaster>;
                //remove the Emplyee Name column from the DataTable
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

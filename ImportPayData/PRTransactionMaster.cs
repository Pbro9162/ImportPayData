using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportPayData
{
    public class PRTransactionMaster
    {
        public int IDGLCompany { get; set; }
        public string CGLCompanyID { get; set; }
        public int IDPREEmployee { get; set; }

        public string CEmployeeName { get; set; }
        public string CCheckNumber { get; set; }
        public DateTime DCheckDate { get; set; }
        public DateTime DAccountingDate { get; set; }
        public DateTime DPayPeriodStart { get; set; }
        public DateTime DPayPeriodEnd { get; set; }
        public decimal NGrossAmount { get; set; }

        public decimal NNetAmount { get; set; }

        public decimal NRegularPay { get; set; }

        public decimal NOvertimePay { get; set; }

        public decimal NTimeOffPay { get; set; }

        public decimal NRegularHours { get; set; }

        public decimal NOvertimeHours { get; set; }

        public decimal NTimeOffHours { get; set; }

        public decimal NDoNotPayHours { get; set; }

        public bool BPRModule { get; set; }

        public string CImportBatchID { get; set; }
        // Additional properties can be added as needed


    }
    public static class ListToDataTableConverter
    {
        /// <summary>
        /// Converts a List of objects to a DataTable.
        /// </summary>
        /// <typeparam name="T">The type of objects in the list.</typeparam>
        /// <param name="data">The list of objects to convert.</param>
        /// <returns>A DataTable containing the data from the list.</returns>
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            // Get the properties of the type T
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();

            // Create columns in the DataTable based on the properties
            foreach (PropertyDescriptor prop in properties)
            {
                // Handle nullable types correctly
                Type columnType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                table.Columns.Add(prop.Name, columnType);
            }

            // Populate the DataTable rows with data from the list
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    // Get the value of each property for the current item
                    object value = prop.GetValue(item);
                    // Handle null values by converting them to DBNull.Value
                    row[prop.Name] = value ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }

            return table;
        }
    }

}

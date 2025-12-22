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
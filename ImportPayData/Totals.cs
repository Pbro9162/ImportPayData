using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportPayData
{
    public class Totals
    {
        public decimal grossTotal { get; set; }
        public decimal netTotal { get; set; }
        public decimal regularPayTotal { get; set; }
        public decimal overtimePayTotal { get; set; }

        public decimal timeOffPayTotal { get; set; }

        public decimal regularHoursTotal { get; set; }

        public decimal overtimeHoursTotal { get; set; }

        public decimal timeOffHoursTotal { get; set; }

        public decimal doNotPayHoursTotal { get; set; }

    }
}

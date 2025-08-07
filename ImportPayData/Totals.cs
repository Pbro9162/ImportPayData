using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportPayData
{
    public class Totals
    {
        public int grossTotal { get; set; }
        public int netTotal { get; set; }
        public int regularPayTotal { get; set; }
        public int overtimePayTotal { get; set; }

        public int timeOffPayTotal { get; set; }

        public int regularHoursTotal { get; set; }

        public int overtimeHoursTotal { get; set; }

        public int timeOffHoursTotal { get; set; }

        public int doNotPayHoursTotal { get; set; }
    }
}

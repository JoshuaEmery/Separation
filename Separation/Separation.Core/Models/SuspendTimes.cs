using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class SuspendTimes
    {
        public SuspendTimes()
        {
            Reports = new HashSet<Reports>();
        }

        public int SuspendId { get; set; }
        public int? NumberOfDays { get; set; }
        public string DaysOut { get; set; }

        public virtual ICollection<Reports> Reports { get; set; }
    }
}

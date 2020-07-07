using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class FollowUps
    {
        public int FollowUpId { get; set; }
        public string FollowUpSummary { get; set; }
        public DateTime? FollowUpDate { get; set; }
        public int? StaffId { get; set; }
        public int? ReportId { get; set; }

        public virtual Reports Report { get; set; }
        public virtual Staff Staff { get; set; }
    }
}

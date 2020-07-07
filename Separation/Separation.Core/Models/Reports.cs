using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class Reports
    {
        public Reports()
        {
            BarCodeNumbers = new HashSet<BarCodeNumbers>();
            FollowUps = new HashSet<FollowUps>();
        }

        public int ReportId { get; set; }
        public int? ClientId { get; set; }
        public int? IncidentId { get; set; }
        public int? SuspendId { get; set; }
        public DateTime? IncidentDate { get; set; }
        public string Summary { get; set; }
        public string PoliceCaseNum { get; set; }
        public int? StaffId { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string FollowUpSummary { get; set; }
        public DateTime? FollowUpDate { get; set; }
        public DateTime? ReportDate { get; set; }
        public string ReportPage { get; set; }
        public int? DepartmentId { get; set; }
        public DateTime? ReturnDateSundown { get; set; }

        public virtual Clients Client { get; set; }
        public virtual Departments Department { get; set; }
        public virtual Incidents Incident { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual SuspendTimes Suspend { get; set; }
        public virtual ICollection<BarCodeNumbers> BarCodeNumbers { get; set; }
        public virtual ICollection<FollowUps> FollowUps { get; set; }
    }
}

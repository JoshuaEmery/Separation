using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class ServiceIssues
    {
        public ServiceIssues()
        {
            Clients = new HashSet<Clients>();
        }

        public int ServiceIssuesId { get; set; }
        public string ServiceSummary { get; set; }

        public virtual ICollection<Clients> Clients { get; set; }
    }
}

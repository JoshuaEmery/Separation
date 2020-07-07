using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class Incidents
    {
        public Incidents()
        {
            Reports = new HashSet<Reports>();
        }

        public int IncidentId { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Reports> Reports { get; set; }
    }
}

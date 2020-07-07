using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class Dependents
    {
        public Dependents()
        {
            Clients = new HashSet<Clients>();
        }

        public int DependentId { get; set; }
        public string DependentStatus { get; set; }

        public virtual ICollection<Clients> Clients { get; set; }
    }
}

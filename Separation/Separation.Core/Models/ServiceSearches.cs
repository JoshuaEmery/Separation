using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class ServiceSearches
    {
        public ServiceSearches()
        {
            Clients = new HashSet<Clients>();
        }

        public int ServiceSearchId { get; set; }
        public string ServiceCategory { get; set; }

        public virtual ICollection<Clients> Clients { get; set; }
    }
}

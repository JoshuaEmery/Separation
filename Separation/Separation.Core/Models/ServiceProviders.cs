using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class ServiceProviders
    {
        public ServiceProviders()
        {
            Clients = new HashSet<Clients>();
        }

        public int ServiceProviderId { get; set; }
        public string ServiceProvider { get; set; }

        public virtual ICollection<Clients> Clients { get; set; }
    }
}

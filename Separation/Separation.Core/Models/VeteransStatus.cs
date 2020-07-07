using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class VeteransStatus
    {
        public VeteransStatus()
        {
            Clients = new HashSet<Clients>();
        }

        public int VeteransStatusId { get; set; }
        public string VeteranStatus { get; set; }

        public virtual ICollection<Clients> Clients { get; set; }
    }
}

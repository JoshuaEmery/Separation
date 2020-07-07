using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class MaritalStatuses
    {
        public MaritalStatuses()
        {
            Clients = new HashSet<Clients>();
        }

        public int MaritalStatusId { get; set; }
        public string MaritalStatus { get; set; }

        public virtual ICollection<Clients> Clients { get; set; }
    }
}

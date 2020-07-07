using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class Identifications
    {
        public Identifications()
        {
            Clients = new HashSet<Clients>();
        }

        public int IdentificationId { get; set; }
        public string Identification { get; set; }

        public virtual ICollection<Clients> Clients { get; set; }
    }
}

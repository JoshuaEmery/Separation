using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class CitizenShips
    {
        public CitizenShips()
        {
            Clients = new HashSet<Clients>();
        }

        public int CitizenshipId { get; set; }
        public string Citizenship { get; set; }

        public virtual ICollection<Clients> Clients { get; set; }
    }
}

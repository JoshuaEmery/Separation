using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class CitiesLastSlept
    {
        public CitiesLastSlept()
        {
            Clients = new HashSet<Clients>();
        }

        public int CitySleptId { get; set; }
        public string CityName { get; set; }

        public virtual ICollection<Clients> Clients { get; set; }
    }
}

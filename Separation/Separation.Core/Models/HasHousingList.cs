using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class HasHousingList
    {
        public HasHousingList()
        {
            Clients = new HashSet<Clients>();
        }

        public int HasHousingId { get; set; }
        public string HasHousing { get; set; }

        public virtual ICollection<Clients> Clients { get; set; }
    }
}

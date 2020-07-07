using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class Ethnicity
    {
        public Ethnicity()
        {
            Clients = new HashSet<Clients>();
        }

        public int EthnicityId { get; set; }
        public string Ethnicity1 { get; set; }

        public virtual ICollection<Clients> Clients { get; set; }
    }
}

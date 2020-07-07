using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class YearsOfHomelessness
    {
        public YearsOfHomelessness()
        {
            Clients = new HashSet<Clients>();
        }

        public int YearsOfHomelessnessId { get; set; }
        public string HomelessnessTime { get; set; }

        public virtual ICollection<Clients> Clients { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class YearsInWashington
    {
        public YearsInWashington()
        {
            Clients = new HashSet<Clients>();
        }

        public int YearsInWashingtonId { get; set; }
        public int? InWashingtonTime { get; set; }

        public virtual ICollection<Clients> Clients { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class YearsInAuburn
    {
        public YearsInAuburn()
        {
            Clients = new HashSet<Clients>();
        }

        public int YearsInAuburnId { get; set; }
        public int? InAuburnTime { get; set; }

        public virtual ICollection<Clients> Clients { get; set; }
    }
}

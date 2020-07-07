using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class Hygienes
    {
        public Hygienes()
        {
            HygieneClients = new HashSet<HygieneClients>();
        }

        public int HygieneId { get; set; }
        public string Item { get; set; }
        public bool? IsChecked { get; set; }

        public virtual ICollection<HygieneClients> HygieneClients { get; set; }
    }
}

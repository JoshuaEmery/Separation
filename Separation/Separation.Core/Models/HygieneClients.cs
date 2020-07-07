using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class HygieneClients
    {
        public int HygieneClientId { get; set; }
        public int? ClientId { get; set; }
        public int? HygieneId { get; set; }
        public DateTime? HygieneDate { get; set; }
        public bool? IsSelected { get; set; }

        public virtual Clients Client { get; set; }
        public virtual Hygienes Hygiene { get; set; }
    }
}

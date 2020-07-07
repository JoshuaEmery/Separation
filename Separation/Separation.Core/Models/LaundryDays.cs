using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class LaundryDays
    {
        public int LaundryId { get; set; }
        public int? ClientId { get; set; }
        public DateTime? LaundryDate { get; set; }
        public DateTime? NextLaundryDate { get; set; }

        public virtual Clients Client { get; set; }
    }
}

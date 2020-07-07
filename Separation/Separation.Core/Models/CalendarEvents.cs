using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class CalendarEvents
    {
        public int CalendarEventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? VendorId { get; set; }
        public DateTime? StartMeal { get; set; }
        public DateTime? EndMeal { get; set; }

        public virtual Vendors Vendor { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class Vendors
    {
        public Vendors()
        {
            CalendarEvents = new HashSet<CalendarEvents>();
        }

        public int VendorId { get; set; }
        public string Organization { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<CalendarEvents> CalendarEvents { get; set; }
    }
}

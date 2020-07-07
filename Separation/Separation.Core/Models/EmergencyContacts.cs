using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class EmergencyContacts
    {
        public int EmergencyContactId { get; set; }
        public string EmergencyContactFname { get; set; }
        public string EmergencyContactLname { get; set; }
        public string EmergencyContactPhone { get; set; }
        public string Relationship { get; set; }
        public int? ClientId { get; set; }

        public virtual Clients Client { get; set; }
    }
}

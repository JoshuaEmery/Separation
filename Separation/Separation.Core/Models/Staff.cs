using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class Staff
    {
        public Staff()
        {
            ClientNotes = new HashSet<ClientNotes>();
            FollowUps = new HashSet<FollowUps>();
            Reports = new HashSet<Reports>();
        }

        public int StaffId { get; set; }
        public string StaffFname { get; set; }
        public string StaffLname { get; set; }

        public virtual ICollection<ClientNotes> ClientNotes { get; set; }
        public virtual ICollection<FollowUps> FollowUps { get; set; }
        public virtual ICollection<Reports> Reports { get; set; }
    }
}

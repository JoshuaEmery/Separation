using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class ClientNotes
    {
        public int ClientNoteId { get; set; }
        public int? ClientId { get; set; }
        public DateTime? NoteDate { get; set; }
        public string Summary { get; set; }
        public int? StaffId { get; set; }

        public virtual Clients Client { get; set; }
        public virtual Staff Staff { get; set; }
    }
}

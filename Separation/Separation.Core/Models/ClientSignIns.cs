using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class ClientSignIns
    {
        public int ClientSignInId { get; set; }
        public int? ClientId { get; set; }
        public DateTime? SignIn { get; set; }

        public virtual Clients Client { get; set; }
    }
}

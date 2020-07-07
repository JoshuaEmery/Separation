using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class Genders
    {
        public Genders()
        {
            Clients = new HashSet<Clients>();
        }

        public int GenderId { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<Clients> Clients { get; set; }
    }
}

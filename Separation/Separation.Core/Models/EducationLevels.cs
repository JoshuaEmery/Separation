using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class EducationLevels
    {
        public EducationLevels()
        {
            Clients = new HashSet<Clients>();
        }

        public int EducationLevelId { get; set; }
        public string EducationLevel { get; set; }

        public virtual ICollection<Clients> Clients { get; set; }
    }
}

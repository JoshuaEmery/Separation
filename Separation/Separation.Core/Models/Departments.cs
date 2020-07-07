using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class Departments
    {
        public Departments()
        {
            Reports = new HashSet<Reports>();
        }

        public int DepartmentId { get; set; }
        public string Department { get; set; }

        public virtual ICollection<Reports> Reports { get; set; }
    }
}

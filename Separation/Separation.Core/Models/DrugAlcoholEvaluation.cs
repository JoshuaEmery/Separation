using System;
using System.Collections.Generic;

namespace Separation.Core.Models
{
    public partial class DrugAlcoholEvaluation
    {
        public DrugAlcoholEvaluation()
        {
            Clients = new HashSet<Clients>();
        }

        public int DrugAlcoholEvaluationId { get; set; }
        public string EvalutionCategory { get; set; }

        public virtual ICollection<Clients> Clients { get; set; }
    }
}

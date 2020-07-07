using Separation.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Separation.Core.Reopositories
{
    public interface IReportsRepository : IRepository<Reports>
    {
        IEnumerable<Reports> ReportsByClientId(int clientId);
    }
}

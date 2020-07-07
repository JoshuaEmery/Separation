using Separation.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Separation.Core.Services
{
    public interface IReportsService : IService<Reports>
    {
        IEnumerable<Reports> ReportsByClientId(int clientId);
    }
}

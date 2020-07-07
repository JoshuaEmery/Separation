using Separation.Core.Models;
using Separation.Core.Reopositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Separation.Data.Repositories
{
    public class ReportsRepository : Repository<Reports>, IReportsRepository
    {
        public ReportsRepository(RayHopeBackupContext context) : base(context)
        {

        }
        public IEnumerable<Reports> ReportsByClientId(int clientId)
        {
            return _context.Reports.Where(x => x.ClientId == clientId);
        }
    }
}

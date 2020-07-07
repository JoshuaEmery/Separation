using Separation.Core.Models;
using Separation.Core.Reopositories;
using Separation.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Separation.Services.Services
{
    public class ReportsService : IReportsService
    {
        private IReportsRepository _reportsRepository;

        public ReportsService(IReportsRepository repository)
        {
            _reportsRepository = repository;
        }
        public IEnumerable<Reports> Find(Expression<Func<Reports, bool>> predicate)
        {
            return _reportsRepository.Find(predicate);
        }

        public IEnumerable<Reports> GetAll()
        {
            return _reportsRepository.GetAll();
        }

        public Reports GetById(int id)
        {
            return _reportsRepository.GetById(id);
        }

        public IEnumerable<Reports> ReportsByClientId(int clientId)
        {
            return _reportsRepository.ReportsByClientId(clientId);
        }
    }
}

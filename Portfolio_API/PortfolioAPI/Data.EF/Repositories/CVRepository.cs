using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.EF.Contexts;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Data.EF.Repositories
{
    public class CVRepository : ICVRepository
    {
        private readonly PortfolioContext _portfolioContext;

        public CVRepository(PortfolioContext portfolioContext)
        {
            _portfolioContext = portfolioContext;
        }

        public IEnumerable<CV> GetAllCVs()
        {
            return _portfolioContext.CVs.ToArray();
        }
    }
}

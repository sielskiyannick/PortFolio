using System;
using System.Collections.Generic;
using System.Linq;
using Data.EF.Contexts.Portfolio;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.EF.Repositories
{
    public interface ICVRepository
    {
        IEnumerable<CV> GetAllCVs();
        CV GetById(Guid id);
    }

    public class CVRepository : ICVRepository
    {
        private readonly PortfolioContext _portfolioContext;

        public CVRepository(PortfolioContext portfolioContext)
        {
            _portfolioContext = portfolioContext;
        }

        public IEnumerable<CV> GetAllCVs()
        {
            return _portfolioContext.CVs
                .Include(cv => cv.CVEntries)
                .ToArray();
        }

        public CV GetById(Guid id)
        {
            return _portfolioContext.CVs
                .Include(cv => cv.CVEntries)
                .FirstOrDefault(cv => cv.Id == id);
        }
    }
}

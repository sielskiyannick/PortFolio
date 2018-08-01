using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.EF.Contexts
{
    public class PortfolioContext: DbContext
    {
        public virtual DbSet<CV> CVs { get; set; }

        public PortfolioContext(DbContextOptions<PortfolioContext> options): base(options)
        {
        }
    }
}

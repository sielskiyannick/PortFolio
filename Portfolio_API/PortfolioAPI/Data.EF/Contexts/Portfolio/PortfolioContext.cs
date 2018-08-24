using Data.EF.Contexts.Portfolio.Configurations;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.EF.Contexts.Portfolio
{
    public class PortfolioContext : DbContext
    {
        public virtual DbSet<CV> CVs { get; set; }

        public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //to do: service resolver (/locator ?)
            var cvConfig = new CVConfiguration();
            var cvEntryConfig = new CVEntryConfiguration();

            cvConfig.Configure(modelBuilder);
            cvEntryConfig.Configure(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}

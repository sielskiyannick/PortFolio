using Data.EF.Core;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.EF.Contexts.Portfolio.Configurations
{
    public class CVConfiguration : IConfigurationBase
    {
        public void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CV>()
                .ToTable("CVs");
        }
    }
}

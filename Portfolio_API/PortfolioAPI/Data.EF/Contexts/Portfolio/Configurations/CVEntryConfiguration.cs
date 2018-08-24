using Data.EF.Core;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.EF.Contexts.Portfolio.Configurations
{
    public class CVEntryConfiguration : IConfigurationBase
    {
        public void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CVEntry>()
                .ToTable("CVEntries");
        }
    }
}

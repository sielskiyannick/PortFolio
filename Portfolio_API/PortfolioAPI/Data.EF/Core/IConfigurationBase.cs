using Microsoft.EntityFrameworkCore;

namespace Data.EF.Core
{
    public interface IConfigurationBase
    {
        void Configure(ModelBuilder modelBuilder);
    }
}

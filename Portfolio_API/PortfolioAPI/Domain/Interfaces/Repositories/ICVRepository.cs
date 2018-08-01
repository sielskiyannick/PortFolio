using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface ICVRepository
    {
        IEnumerable<CV> GetAllCVs();
    }
}

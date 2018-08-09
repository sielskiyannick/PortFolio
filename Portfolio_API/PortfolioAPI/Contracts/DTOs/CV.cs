using System.Collections.Generic;

namespace Contracts.DTOs
{
    public class CV
    {
        public IEnumerable<CVEntry> CVEntries { get; set; }
    }
}

using System;
using System.Collections.Generic;
using Domain.Core;

namespace Domain.Entities
{
    public class CV: EntityBase<Guid>
    {
        public List<CVEntry> CVEntries { get; set; }
    }
}

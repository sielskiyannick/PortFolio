using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Common.Core;

namespace Domain.Entities
{
    [Table("CVs")]
    public class CV: EntityBase<Guid>
    {
        public ICollection<CVEntry> CVEntries { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations.Schema;
using Common.Core;

namespace Domain.Entities
{
    [Table("CVEntries")]
    public class CVEntry : EntityBase<Guid>
    {
        public string Title { get; set; }
        public CV CV { get; set; }
    }
}

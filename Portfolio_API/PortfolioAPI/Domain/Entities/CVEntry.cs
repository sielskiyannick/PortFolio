using System;
using Domain.Core;

namespace Domain.Entities
{
    public class CVEntry : EntityBase<Guid>
    {
        public string Title { get; set; }
        public Guid CVId { get; set; }
    }
}

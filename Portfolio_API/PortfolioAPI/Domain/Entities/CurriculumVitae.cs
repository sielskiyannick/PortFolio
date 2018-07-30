using System;
using System.Collections.Generic;
using System.Text;
using Common.Core;

namespace Domain.Entities
{
    public class CurriculumVitae: EntityBase<Guid>
    {
        public string TestText { get; set; }
    }
}

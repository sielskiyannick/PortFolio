using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Core
{
    public abstract class EntityBase<TId>
    {
        public TId Id { get; set; }
    }
}

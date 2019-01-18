using System;
using System.Collections.Generic;
using System.Text;

namespace Wu17.Picks.Core.Base
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; }
    }
}

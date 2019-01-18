using System;
using System.Collections.Generic;
using System.Text;

namespace Wu17.Picks.Core
{
    public interface IEntity
    {
        Guid Id { get; set; }
        DateTime DateCreated { get; set; }
        bool IsDeleted { get; set; }
    }
}

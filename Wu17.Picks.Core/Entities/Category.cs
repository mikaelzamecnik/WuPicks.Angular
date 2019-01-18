using System;
using System.Collections.Generic;
using System.Text;
using Wu17.Picks.Core.Base;

namespace Wu17.Picks.Core.Entities
{
    public class Category: BaseEntity
    {
        public string Name { get; set; }
        public Guid ImageReferenceId { get; set; }
        public ImageReference ImageReference { get; set; }
    }
}

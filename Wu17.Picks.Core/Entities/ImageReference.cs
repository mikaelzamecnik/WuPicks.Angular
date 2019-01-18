using System;
using System.Collections.Generic;
using System.Text;
using Wu17.Picks.Core.Base;

namespace Wu17.Picks.Core.Entities
{
    public class ImageReference:BaseEntity
    {
        public string FilePath { get; set; }
        public string Description { get; set; }
    }
}

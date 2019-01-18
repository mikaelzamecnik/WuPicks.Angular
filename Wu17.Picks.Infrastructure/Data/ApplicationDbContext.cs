using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Wu17.Picks.Core.Entities;

namespace Wu17.Picks.Infrastructure.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
             : base(options) { }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ImageReference> ImageReferences { get; set; }

    }
}

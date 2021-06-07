using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TLOSoltuion.Data.Entities;

namespace TLOSoltuion.Data.EF
{
    public class TLODbContext : IdentityDbContext<User>
    {
        public TLODbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Post> Post { get; set; }
    }

}

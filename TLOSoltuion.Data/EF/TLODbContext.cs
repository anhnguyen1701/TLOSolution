using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TLOSoltuion.Data.Configurations;
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
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
        }

        public DbSet<Post> Post { get; set; }
        public DbSet<Category> Category { get; set; }
    }

}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TLOSoltuion.Data.Entities;

namespace TLOSoltuion.Data.Configurations
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = "2dce503c-3842-4350-891b-c4c339882ece",
                    FirstName = "Publiser 1",
                    LastName = "TailieuOnline",
                    UserName = "publisher@gmail.com",
                    Email =  "publisher@gmail.com"
                });
        }
    }
}

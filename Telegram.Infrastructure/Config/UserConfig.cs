using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Domain;

namespace Telegram.Infrastructure.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> x)
        {
            x.HasKey(x => x.Id);
            x.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("nvarchar");
            x.Property(x => x.Login)
                .IsRequired()
                .HasColumnType("nvarchar");
            x.Property(x => x.Password)
                .IsRequired()
                .HasColumnType("nvarchar");
        }

    }
}

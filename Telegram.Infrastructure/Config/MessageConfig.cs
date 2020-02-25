using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Domain;

namespace Telegram.Infrastructure.Config
{
    public class MessageConfig : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> x)
        {
            x.HasKey(x => x.Id);
            x.Property(x => x.SendTime)
                .IsRequired()
                .HasColumnType("datetime");
            x.Property(x => x.Text)
                .IsRequired()
                .HasColumnType("nvarchar(20)");

            x.HasOne(x => x.User)
                .WithMany(x => x.Messages)
                .HasForeignKey(x => x.UserId);
        }
    }
}

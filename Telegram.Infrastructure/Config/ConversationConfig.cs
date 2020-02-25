using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telegram.Domain;

namespace Telegram.Infrastructure.Config
{
    public class ConversationConfig : IEntityTypeConfiguration<Conversation>
    {
        public void Configure(EntityTypeBuilder<Conversation> x)
        {
            x.HasKey(x => x.Id);
            x.Property(x => x.ConvName)
                .IsRequired()
                .HasColumnType("nvarchar");
            x.Property(x => x.CreateDate)
                .IsRequired()
                .HasColumnType("datetime");
        }
    }
}

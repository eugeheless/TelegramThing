using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telegram.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Telegram.Infrastructure.Config
{
    public class UserConversationConfig : IEntityTypeConfiguration<UserConversation>
    {
        public void Configure(EntityTypeBuilder<UserConversation> x)
        {
            x.HasKey(x => new { x.UserId, x.ConversId });
            //x.HasAlternateKey(x => new { x.UserId, x.MessageId });
            //x.HasAlternateKey(x => new { x.ConversId, x.MessageId });

            x.HasOne(x => x.User)
                .WithMany(x => x.Conversations)
                .HasForeignKey(x => x.UserId);
            x.HasOne(x => x.Conversation)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.ConversId);

            //x.HasOne(x => x.User)
            //    .WithMany(x => x.Messages)
            //    .HasForeignKey(x => x.UserId);
            //x.HasOne(x => x.Message)
            //    .WithMany(x => x.Users)
            //    .HasForeignKey(x => x.MessageId);

            //x.HasOne(x => x.Conversation)
            //    .WithMany(x => x.Messages)
            //    .HasForeignKey(x => x.ConversId);
            //x.HasOne(x => x.Message)
            //    .WithMany(x => x.Conversations)
            //    .HasForeignKey(x => x.MessageId);

        }
    }
}

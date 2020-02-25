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

        }
    }
}

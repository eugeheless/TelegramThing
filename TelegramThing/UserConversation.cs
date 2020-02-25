using System;
using System.Collections.Generic;
using System.Text;

namespace Telegram.Domain
{
    public class UserConversation
    {
        public int UserId { get; set; }
        public int ConversId { get; set; }
        public User User { get; set; }
        public Conversation Conversation { get; set; }


        public virtual ICollection<Message> Messages { get; set; }
        public UserConversation()
        {
            Messages = new HashSet<Message>();
        }



    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Telegram.Domain
{
    public class Message
    {
        public int Id { get; set; }
        public DateTime SendTime { get; set; }
        public string Text { get; set; }

        public virtual ICollection<UserConversation> Messages { get; set; }
        public Message()
        {
            Messages = new HashSet<UserConversation>();
        }
    }
}

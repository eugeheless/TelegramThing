using System;
using System.Collections.Generic;
using System.Text;

namespace Telegram.Domain
{
    public class Conversation
    {
        public int Id { get; set; }
        public string ConvName { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual ICollection<UserConversation> Conversations { get; set; }
        public Conversation()
        {
            Conversations = new HashSet<UserConversation>();
        }
    }
}

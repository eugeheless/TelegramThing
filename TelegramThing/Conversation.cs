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

        public virtual ICollection<UserConversation> Users { get; set; }
        //public virtual ICollection<Message> Messages { get; set; }
        public Conversation()
        {
            Users = new HashSet<UserConversation>();
            //Messages = new HashSet<Message>();
        }
    }
}

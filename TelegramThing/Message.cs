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


        public int UserConversationId { get; set; }
        public int UserConversation1Id { get; set; }

        public UserConversation UserConversation { get; set; }
        
        
        
        
        
        
        
        //public virtual ICollection<UserConversation> Users { get; set; }
        //public Message()
        //{
        //    Users = new HashSet<UserConversation>();
        //}
    }
}

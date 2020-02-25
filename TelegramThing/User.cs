using System;
using System.Collections.Generic;
using System.Text;

namespace Telegram.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }

        public virtual ICollection<UserConversation> Conversations { get; set; }

        //public virtual ICollection<Message> Messages { get; set; }
        public User()
        {
            Conversations = new HashSet<UserConversation>();
            //Messages = new HashSet<Message>();
        }

    }
}

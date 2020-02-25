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

        public virtual ICollection<UserConversation> Users { get; set; }
        public User()
        {
            Users = new HashSet<UserConversation>();
        }

    }
}

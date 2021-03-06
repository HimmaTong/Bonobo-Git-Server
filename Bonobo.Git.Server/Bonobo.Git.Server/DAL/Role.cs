using System;
using System.Collections.Generic;

namespace Bonobo.Git.Server.DAL
{
    public partial class Role
    {
        public Role()
        {
            this.Users = new List<User>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}

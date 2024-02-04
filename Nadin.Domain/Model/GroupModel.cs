using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nadin.Domain.Model
{
    public class GroupModel
    {
        public string Caption { get; set; }
        public bool IsPermissionBase { get; set; }

        public virtual ICollection<User> Users { get; set; } = new List<User>();
        public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
    }
}

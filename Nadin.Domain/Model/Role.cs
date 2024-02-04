using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Nadin.Domain.Model
{
    public class Role
    {
        public string Title { get; set; }
        public string DisplayTitle { get; set; }
        public string Discriminator { get; set; }

        public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
    }
}

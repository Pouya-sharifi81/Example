using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nadin.Domain.Model
{
    public class UserLogin
    {
        public int UserId { get; set; }
        public string IpAddress { get; set; }
        public string ExtraInfo { get; set; }
        public DateTime CreatedDate { get; set; }


        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}

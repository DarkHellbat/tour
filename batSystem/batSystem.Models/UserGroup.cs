using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batSystem.Models
{
    public class UserGroup
    {
        public long UserGroupID { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
        public List<User> UserList { get; set; }
        public File GroupAvatar { get; set; }
        public Permission AccessPermition { get; set; }
    }
}

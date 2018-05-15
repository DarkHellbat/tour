using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batSystem.Models
{
    class UserGroup
    {
        long UserGroupID { get; set; }
        string GroupName { get; set; }
        string Description { get; set; }
        List<User> UserList { get; set; }
        File GroupAvatar { get; set; }
        Permission AccessPermition { get; set; }
    }
}

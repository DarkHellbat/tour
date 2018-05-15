using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batSystem.Models
{
    class Permission
    {
        long PermissionID { get; set; }
        int PermissionLevel { get; set; }
        string Description { get; set; }
    }
}

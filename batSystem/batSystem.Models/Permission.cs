using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batSystem.Models
{
    public class Permission
    {
        public long PermissionID { get; set; }
        public int PermissionLevel { get; set; }
        public string Description { get; set; }
    }
}

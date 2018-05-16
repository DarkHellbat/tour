using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batSystem.Models
{
   public class User
    {
        public long UserID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public File Avatar { get; set; }
        public string Email { get; set; }
        public DateTime DateofBirth { get; set; }
        public Enum Status { get; set; }
        //UserGroup Usergroup { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batSystem.Models
{
    class User
    {
        long UserID { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        string Salt { get; set; }
        string LastName { get; set; }
        string FirstName { get; set; }
        string SecondName { get; set; }
        File Avatar { get; set; }
        string Email { get; set; }
        DateTime DateofBirth { get; set; }
        Enum Status { get; set; }
        //UserGroup Usergroup { get; set; }
    }
}

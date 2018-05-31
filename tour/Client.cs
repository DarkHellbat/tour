using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tour
{
    public class Client
    {
        public int ClientID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int PassportNum { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public override string ToString()
        {
            return LastName+", "+FirstName;
        }
    }
}

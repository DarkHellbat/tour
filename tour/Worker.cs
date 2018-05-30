using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tour
{
    public class Worker
    {
        public int Id { get; set; }
       // public client ClientID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public Position Position { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public override string ToString()
        {
            return this.LastName + ", " + this.FirstName;
        }
    }
}

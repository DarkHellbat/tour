using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batSystem.Models
{
     class Ref
    {
        [Attribute]
        public void rr(object obj)
        {

            typeof(Ref).GetMethods().Where(m => m.CustomAttributes);
            obj.GetType().GetMethods().Where(m => m.CustomAttributes);
        }
    }
}

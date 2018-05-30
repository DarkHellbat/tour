using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tour
{
    public class Complain
    {
        public int ComplainID { get; set; }
        public Order Order { get; set; }
        public string Text { get; set; }
        public CType Type { get; set; }
    }
}

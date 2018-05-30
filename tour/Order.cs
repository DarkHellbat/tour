using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tour
{
    public class Order
    {
        public int OrderID { get; set; }
        public Client Client { get; set; }
        public Worker Worker { get; set; }
        public Tour Tour { get; set; }
        public Payment Payment { get; set; }
        public DateTime OrderDate { get; set; }
    }
}

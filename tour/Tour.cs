using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tour
{
    public class Tour
    {
        public int TourID { get; set; }
        public string TourName { get; set; }
        public DateTime TourBeginning { get; set; }
        public DateTime TourEnding { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public string Destination { get; set; }
        public int Rate { get; set; }
        public Doc ReqDoc { get; set; }
    }
}

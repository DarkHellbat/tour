using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batSystem.Models
{
    public class File
    {
        public long FileId { get; set; }
        public string Path { get; set; }
        public Enum Type { get; set; }
        public double Size { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batSystem.Models
{
    class File
    {
        long FileId { get; set; }
        string Path { get; set; }
        Enum Type { get; set; }
        double Size { get; set; }
    }
}

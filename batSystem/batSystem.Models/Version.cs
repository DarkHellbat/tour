using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batSystem.Models
{
    class Version
    {
        long VersionID { get; set; }
        File File { get; set; }
        string VersionNumber { get; set; } //на случай если версия имеет формат "3.12.1554"
        Document Document { get; set; } //в версии есть ссылка на документ, а в документе - лист версий - ?
        DateTime CreationDate { get; set; }
        DateTime ChangeDate { get; set; }
        User Author { get; set; }
        Enum Status { get; set; }

    }
}

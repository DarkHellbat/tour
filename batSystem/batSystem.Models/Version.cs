using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batSystem.Models
{
    public class Version
    {
        public long VersionID { get; set; }
        public File File { get; set; }
        public string VersionNumber { get; set; } //на случай если версия имеет формат "3.12.1554"
        public Document Document { get; set; } //в версии есть ссылка на документ, а в документе - лист версий - ?
        public DateTime CreationDate { get; set; }
        public DateTime ChangeDate { get; set; }
        public User Author { get; set; }
        public Enum Status { get; set; }

    }
}

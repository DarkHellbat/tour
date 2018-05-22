using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batSystem.Models
{
    public class Document : Folder
    {
        public virtual long DocumentID { get; set; }
        public virtual string Description { get; set; }
        public virtual List<Version> VersionList { get; set; }
        public virtual string DocumentType { get; set; }
        public virtual List<Commentary> CommentaryList { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batSystem.Models
{
    public class Document : Folder
    {
        public long DocumentID { get; set; }
        public string Description { get; set; }
        public List<Version> VersionList { get; set; }
        public string DocumentType { get; set; }
        publicList<Commentary> CommentaryList { get; set; }


    }
}

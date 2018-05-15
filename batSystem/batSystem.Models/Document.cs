using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batSystem.Models
{
    class Document : Folder
    {
        long DocumentID { get; set; }
        string Description { get; set; }
        List<Version> VersionList { get; set; }
        string DocumentType { get; set; }
        List<Commentary> CommentaryList { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace batSystem.Models
{
     class Folder
    {
         long FolderID {get;set ;}
         string Foldername { get; set; }
        Folder ParentFolder { get; set; }
        DateTime CreationDate { get; set; }
        DateTime ChangeDate { get; set; }
        User Author { get; set; }
        User ChangedBy { get; set; }
        Permission AllowAccessTo { get; set; }

        
        public void PathSearch()
        {
            string partialpath="", fullpath="";
            Folder fold = new Folder();
            while (fold.ParentFolder != null)
            {
                if (fold.ParentFolder != null)
                {

                    partialpath = fullpath;
                    fullpath = fold.Foldername + @"\" + partialpath;
                    fold = ParentFolder;
                }
                else
                {
                    partialpath = fullpath;
                    fullpath = fold.Foldername + @":\" + partialpath;
                }
            }
        }
        //public void FolderTree()
    //    {
    //        List<Folder>[] noparentlist = new List<Folder>[];
    //        Folder currentfolder = new Folder();
    //        int i=0;
            
    //      //  while ()
    //        {
    //            if (currentfolder.ParentFolder==null)
    //            {
    //                noparentlist[i].Add(currentfolder);
    //                i++;
    //                currentfolder.FolderID++;
    //            }
    //            else
    //            {
    //                BinaryExpression condition = Expression.
    //                Expression<Func<>>
    //            }
    //        }
    //    }
    //}
    //class treelist
    //{

    //}
}

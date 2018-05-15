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
        public void FolderTree(List<Folder> folderlist )
        {
            LinkedList<Folder> list = new LinkedList<Folder>();
            
            Folder currentfolder = new Folder();
            for (int i = 0; i< folderlist.Count(); i++)
            {
                currentfolder = folderlist[i];
                if (currentfolder.ParentFolder == null)//если корневая папка - добавляет в начало списка
                    list.AddFirst(currentfolder);
                else
                {
                    Folder parent = currentfolder.ParentFolder;
                   if (list.Contains(parent))//если родительская папка уже есть в дереве - добавляет после нее
                    {
                        list.AddAfter(list.Find(parent), currentfolder);
                    }
                   else//добавляет в качестве последнего элемента текущую папку и затем добавляет перед ней предка
                    {
                        list.AddLast(currentfolder);
                        list.AddBefore(list.Find(currentfolder), parent);
                        //     Folder previous = new Folder();               //вариант 2
                        //     int count = 0;
                        //     List<Folder> path = new List<Folder>();
                        //previous = parent.ParentFolder;
                        //     while (!list.Contains(parent))// пока не найдет родительская папка, которая уже есть в дереве - записывает их
                        //     {
                        //         path[count] = previous;
                        //         count++;
                        //         previous = previous.ParentFolder;

                        //     }
                        //     for (int j = path.Count; j==0; j--)//идет по списку, занося 
                        //     {
                        //         list.AddAfter(list.Find(path[j]), path[j - 1]);
                        //     }
                        //     list.AddAfter(list.Find(path[0]), parent);
                        //     list.AddAfter(list.Find(parent), currentfolder);
                    }
                }
            }
          
        }
    }
    
    
}


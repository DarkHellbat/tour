using batSystem.Models.Repositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batSystem.Models.Skeleton
{
    public class FolderMethods
    {
        [Repository]
        private ISession session;
        //public Base(ISession session)
        //{
        //    this.session = session;
        //}
        public void Add()
        { }
        public void Change()
        { }
        public void Delete()
        { }
        public void GetByChangeDate()
        { }
        public void SaveAsFile()
        { }
    }
}

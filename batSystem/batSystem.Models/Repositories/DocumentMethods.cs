using batSystem.Models.Repositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batSystem.Models.Skeleton
{
    public class DocumentMethods
    {
        [Repository]
        private ISession session;
        public DocumentMethods(ISession session)
        {
            this.session = session;
        }
        public void Add()
        { }
        public void Change()
        { }
        public void Delete()
        { }
        public void GetVersionList()
        { }
        public void SaveAsFile()
        { }
        public void GetByAuthor()
        { }
    }
}


using batSystem.Models.Repositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batSystem.Models.Mappings
{
    public class VersionMethods
    {
        [Repository]
        private ISession session;
        public VersionMethods(ISession session)
        {
            this.session = session;
        }
        public void Add()
        { }
        public void ChangeStatus()
        { }
        public void ChangeAuthor()
        { }
    }
}

using batSystem.Models.Repositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batSystem.Models.Skeleton
{
    public class Base
    {
        [Repository]
        private ISession session;
        public Base(ISession session)
        {
            this.session = session;
        }
        public void Save()
        {

        }
        public void Search(string Name)
        {
            //using (var tr = session.BeginTransaction())
            //{
            //   session.GetEnabledFilter(Name);
            //    //session.fi
            //  //  tr.();
            //}
        }
        public void Load()
        {

        }
        public void GetByName()
        {

        }
       
    }
}

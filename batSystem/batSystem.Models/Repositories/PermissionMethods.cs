using batSystem.Models.Repositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batSystem.Models.Skeleton
{
    public class PermissionMethods
    {
        [Repository]
        private ISession session;
        public PermissionMethods(ISession session)
        {
            this.session = session;
        }

    }
}

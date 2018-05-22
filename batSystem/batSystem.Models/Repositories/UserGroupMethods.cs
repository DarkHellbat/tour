using batSystem.Models.Repositories;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batSystem.Models.Mappings
{
    public class UserGroupMethods
    {
        [Repository]
        private ISession session;
        public UserGroupMethods(ISession session)
        {
            this.session = session;
        }
        public void Add()
        { }
        public void Change()
        { }
        public void Delete()
        { }
        public void ChangeUserList()
        { }
        public IList<User> Users(long groupId)
        {
            var detach = DetachedCriteria.For<User>()
                .CreateAlias("InGroup", "g", JoinType.InnerJoin)
                .Add(Restrictions.Eq("g.Id", groupId))
                .SetProjection(Projections.Id());
            return session.CreateCriteria<User>()
                .Add(Subqueries.In("Id", detach))
                .List<User>();
        }

    }
}

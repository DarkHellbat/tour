using batSystem.Models.Repositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batSystem.Models.Mappings
{
    [Repository]
    public class UserMethods
    {
        private ISession session;
        public UserMethods(ISession session)
        {
            this.session = session;
        }
        public void Add()
        { }
        public User FindByLogin(string login)
        {
            // session.f
            User user = new User();
            return user;
        }
        public void Change(User user)
        {
            using (var tr = session.BeginTransaction())
            {
                session.Update(user);
                tr.Commit();
            }
        }
        public User Load(long id)
        {
            return session.Load<User>(id);
        }
       public User RememberCurrent(User loggegin)
        {
            User user = loggegin;
            return user;
        }
        public List<User> GetAll()
        {
            return session.CreateCriteria<User>()
                .List<User>()
                .ToList();
        }

        public void Save(User user)
        {
            using (var tr = session.BeginTransaction())
            {
                session.Save(user);
                tr.Commit();
            }
        }
        public void SelectByStatus()
        { }
        public void GenerateSalt()
        { }
    }
}

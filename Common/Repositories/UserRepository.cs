using Common.Repositories.Interfaces;
using DataAccess.Context;
using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public class UserRepository : IUserRepository
    {
        private bool status = false;
        private ApplicationContext applicationContext = new ApplicationContext();

        public bool Delete(int id)
        {
            var get = Get(id);
            if (get != null)
            {
                get.Delete();
                applicationContext.Entry(get).State = EntityState.Modified;
                var result = applicationContext.SaveChanges();
                return result > 0;
            }
            else
            {
                return false;
            }
        }

        public List<User> Get()
        {
            var get = applicationContext.Users.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public List<User> Get(string value)
        {
            //roles di application context class
            var get = applicationContext.Users.Where(x => Convert.ToString(x.Id).Contains(value) && x.IsDelete == false).ToList();
            return get;
        }

        public User Get(int id)
        {
            var get = applicationContext.Users.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(UserVM userVM)
        {
            var push = new User(userVM);
            applicationContext.Users.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int id, UserVM userVM)
        {
            var get = Get(id);
            get.Update(userVM);
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }
    }
}

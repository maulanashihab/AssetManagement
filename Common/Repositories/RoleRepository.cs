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
    public class RoleRepository : IRoleRepository
    {
        private bool status = false;
        private ApplicationContext applicationContext = new ApplicationContext();

        //public bool Delete(int id)
        //{
        //    var get = Get(id);
        //    if (get != null)
        //    {
        //        get.Delete();
        //        applicationContext.Entry(get).State = EntityState.Modified;
        //        var result = applicationContext.SaveChanges();
        //        return result > 0;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        public List<Role> Get()
        {
            var get = applicationContext.Roles.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        //public List<Role> Get(string value)
        //{
        //    //roles di application context class
        //    var get = applicationContext.Roles.Where(x => (x.Name.Contains(value) || Convert.ToString(x.Id).Contains(value)) && x.IsDelete == false).ToList();
        //    return get;
        //}

        public Role Get(int id)
        {
            var get = applicationContext.Roles.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(RoleVM roleVM)
        {
            var push = new Role(roleVM);
            applicationContext.Roles.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        //public bool Update(int id, RoleVM roleVM)
        //{
        //    var get = Get(id);
        //    if (get != null)
        //    {
        //        get.Update(roleVM);
        //        applicationContext.Entry(get).State = EntityState.Modified;
        //        var result = applicationContext.SaveChanges();
        //        return result > 0;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}

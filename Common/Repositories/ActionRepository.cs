using Common.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using DataAccess.Context;
using System.Data.Entity;

namespace Common.Repositories
{
    public class ActionRepository : IActionRepository
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

        public List<DataAccess.Models.Action> Get()
        {
            var get = applicationContext.Actions.Where(x => x.IsDelete == false).ToList();
            return get;
        }


        public DataAccess.Models.Action Get(int id)
        {
            var get = applicationContext.Actions.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(ActionVM actionVM)
        {
            var push = new DataAccess.Models.Action(actionVM);
            applicationContext.Actions.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int id, ActionVM actionVM)
        {
            var get = Get(id);
            get.Update(actionVM);
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }
    }
}

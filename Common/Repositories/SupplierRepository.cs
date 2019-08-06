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
    public class SupplierRepository : ISupplierRepository
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

        public List<Supplier> Get()
        {
            var get = applicationContext.Suppliers.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public List<Supplier> Get(string value)
        {
            //roles di application context class
            var get = applicationContext.Suppliers.Where(x => (Convert.ToString(x.Name).Contains(value) || Convert.ToString(x.Id).Contains(value)) && x.IsDelete == false).ToList();
            return get;
        }

        public Supplier Get(int id)
        {
            var get = applicationContext.Suppliers.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(SupplierVM supplierVM)
        {
            var push = new Supplier(supplierVM);
            applicationContext.Suppliers.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int id, SupplierVM supplierVM)
        {
            var get = Get(id);
            get.Update(supplierVM);
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }
    }
}

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
    public class AssetEmployeeRepository : IAssetEmployeeRepository
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

        public List<AssetEmployee> Get()
        {
            var get = applicationContext.AssetEmployees.Where(x => x.IsDelete == false).ToList();
            return get;
        }


        public AssetEmployee Get(int id)
        {
            var get = applicationContext.AssetEmployees.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(AssetEmployeeVM assetemployeeVM)
        {
            var push = new AssetEmployee(assetemployeeVM);
            var getStatus = applicationContext.Actions.SingleOrDefault(x => x.IsDelete == false && x.Id == assetemployeeVM.ActionId);
            var getEmployee = applicationContext.Employees.SingleOrDefault(x => x.IsDelete == false && x.Id == assetemployeeVM.EmployeeId);
            var getAsset = applicationContext.Assets.SingleOrDefault(x => x.IsDelete == false && x.Id == assetemployeeVM.AssetId);
            push.Action = getStatus; 
            push.Employee = getEmployee; 
            push.Asset = getAsset;
            applicationContext.AssetEmployees.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int id, AssetEmployeeVM assetemployeeVM)
        {
            var get = Get(id);
            get.Update(assetemployeeVM);
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }
    }
}

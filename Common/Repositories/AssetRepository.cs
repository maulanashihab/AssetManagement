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
    public class AssetRepository : IAssetRepository
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

        public List<Asset> Get()
        {
            var get = applicationContext.Assets.Include("Supplier").Include("Category").Where(x => x.IsDelete == false).ToList();
            return get;
        }


        public Asset Get(int id)
        {
            var get = applicationContext.Assets.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(AssetVM assetVM)
        {
            var push = new Asset(assetVM);
            var getSupplier = applicationContext.Suppliers.SingleOrDefault(x => x.IsDelete == false && x.Id == assetVM.SupplierId);
            var getCategory = applicationContext.Categories.SingleOrDefault(x => x.IsDelete == false && x.Id == assetVM.CategoryId);
            push.Supplier = getSupplier;
            push.Category = getCategory;
            applicationContext.Assets.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int id, AssetVM assetVM)
        {
            var get = Get(id);
            get.Update(assetVM);
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }
    }
}

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
    public class ProvinceRepository : IProvinceRepository
    {
        private bool status = false;
        private ApplicationContext applicationContext = new ApplicationContext();

        public List<Province> Get()
        {
            var get = applicationContext.Provinces.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        //public List<Province> Get(string value)
        //{
        //    //roles di application context class
        //    var get = applicationContext.Provincies.Where(x => (x.Name.Contains(value) || Convert.ToString(x.Id).Contains(value)) && x.IsDelete == false).ToList();
        //    return get;
        //}

        public Province Get(int id)
        {
            var get = applicationContext.Provinces.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(ProvinceVM provinceVM)
        {
            var push = new Province(provinceVM);
            applicationContext.Provinces.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int id, ProvinceVM provinceVM)
        {
            var get = Get(id);
            get.Update(provinceVM);
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Delete(int id)
        {
            var get = Get(id);
            get.Delete();
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }
    }
}

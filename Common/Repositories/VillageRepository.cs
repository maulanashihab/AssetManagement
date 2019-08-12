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
    public class VillageRepository : IVillageRepository
    {
        private bool status = false;
        private ApplicationContext applicationContext = new ApplicationContext();

        //public bool Delete(int id)
        //{
        //    var get = Get(id);
        //    get.Delete();
        //    applicationContext.Entry(get).State = EntityState.Modified;
        //    var result = applicationContext.SaveChanges();
        //    return result > 0;
        //}

        public List<Village> Get()
        {
            var get = applicationContext.Villages.
                        Include("District").
                        Include("District.Regency").
                        Include("District.Regency.Province").
                        Where(x => x.IsDelete == false).ToList();            return get;
        }

        //public List<Village> Get(string value)
        //{
        //    //roles di application context class
        //    var get = applicationContext.Villages.Include("TB_M_District").Where(x => (x.Name.Contains(value) || x.Id.ToString().Contains(value) || x.District.Name.Contains(value)) && x.IsDelete == false).ToList();
        //    return get;
        //}

        public Village Get(int id)
        {
            var get = applicationContext.Villages.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(VillageVM villageVM)
        {
            var push = new Village(villageVM);
            //ini nih foreign key
            var getDistrict = applicationContext.Districts.SingleOrDefault(x => x.IsDelete == false && x.Id == villageVM.DistrictId);
            push.District = getDistrict;
            applicationContext.Villages.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        //public bool Update(int id, VillageVM villageVM)
        //{
        //    var get = Get(id);
        //    get.Update(villageVM);
        //    applicationContext.Entry(get).State = EntityState.Modified;
        //    var result = applicationContext.SaveChanges();
        //    return result > 0;
        //}
    }
}

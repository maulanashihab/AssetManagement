using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Common.Repositories.Interfaces
{
    public interface IDistrictRepository
    {
        List<District> Get();
        District Get(int id);
        List<District> Get(string value);
        bool Insert(DistrictVM districtVM);
        //bool Update(int id, DistrictVM districtVM);
        //bool Delete(int id);
    }
}

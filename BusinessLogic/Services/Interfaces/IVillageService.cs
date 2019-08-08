using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Interfaces
{
    public interface IVillageService
    {
        List<Village> Get();
        Village Get(int id);
        //List<Village> Get(string value);
        bool Insert(VillageVM villageVM);
        //bool Update(int id, VillageVM villageVM);
        //bool Delete(int id);
    }
}

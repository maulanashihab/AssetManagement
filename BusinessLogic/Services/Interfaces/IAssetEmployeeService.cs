using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusineesLogic.Services.Interfaces
{
    public interface IAssetEmployeeService
    {
        List<AssetEmployee> Get();
        AssetEmployee Get(int id);
        //List<AssetEmployee> Get(string value);
        bool Insert(AssetEmployeeVM assetemployeeVM);
        bool Update(int id, AssetEmployeeVM assetemployeeVM);
        bool Delete(int id);
    }
}

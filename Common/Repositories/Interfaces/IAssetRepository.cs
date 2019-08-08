using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories.Interfaces
{
    public interface IAssetRepository
    {
        List<Asset> Get();
        Asset Get(int id);
       // List<Asset> Get(string value);
        bool Insert(AssetVM assetVM);
        bool Update(int id, AssetVM assetVM);
        bool Delete(int id);
    }
}

using BusineesLogic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repositories.Interfaces;

namespace BusinessLogic.Services
{
    public class AssetService : IAssetService
    {
        bool status = false;
        private readonly IAssetRepository _assetRepository;
        public AssetService(IAssetRepository assetRepository)
        {
            _assetRepository = assetRepository;
        }
        public AssetService() { }
        public bool Delete(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                return status;
            }
            else
            {
                var result = _assetRepository.Delete(id);
                return result;
            }
        }

        public List<Asset> Get()
        {
            var result = _assetRepository.Get();
            return result;
        }

        public Asset Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _assetRepository.Get(id);
                return result;
            }
        }

        public bool Insert(AssetVM assetVM)
        {
            if (string.IsNullOrWhiteSpace(assetVM.Name) || string.IsNullOrWhiteSpace(assetVM.Stock.ToString()) || string.IsNullOrWhiteSpace(assetVM.SerialKey.ToString()) || string.IsNullOrWhiteSpace(assetVM.Spesification.ToString()) || string.IsNullOrWhiteSpace(assetVM.SupplierId.ToString()) || string.IsNullOrWhiteSpace(assetVM.CategoryId.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _assetRepository.Insert(assetVM);
                return result;
            }
        }

        public bool Update(int id, AssetVM assetVM)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()) || string.IsNullOrWhiteSpace(assetVM.Name) || string.IsNullOrWhiteSpace(assetVM.Stock.ToString()) || string.IsNullOrWhiteSpace(assetVM.SerialKey.ToString()) || string.IsNullOrWhiteSpace(assetVM.Spesification.ToString()) || string.IsNullOrWhiteSpace(assetVM.SupplierId.ToString()) || string.IsNullOrWhiteSpace(assetVM.CategoryId.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _assetRepository.Update(id,assetVM);
                return result;
            }
        }
    }
}

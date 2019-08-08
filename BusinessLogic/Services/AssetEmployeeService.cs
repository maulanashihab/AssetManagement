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
    public class AssetEmployeeService : IAssetEmployeeService
    {
        bool status = false;
        private readonly IAssetEmployeeRepository _assetEmployeeRepository;
        public AssetEmployeeService(IAssetEmployeeRepository assetEmployeeRepository)
        {
            _assetEmployeeRepository = assetEmployeeRepository;
        }
        public AssetEmployeeService() { }
        public bool Delete(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                return status;
            }
            else
            {
                var result = _assetEmployeeRepository.Delete(id);
                return result;
            }
        }

        public List<AssetEmployee> Get()
        {
            var result = _assetEmployeeRepository.Get();
            return result;
        }

        public AssetEmployee Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _assetEmployeeRepository.Get(id);
                return result;
            }
        }

        public bool Insert(AssetEmployeeVM assetemployeeVM)
        {
            if (string.IsNullOrWhiteSpace(assetemployeeVM.LoanDate.ToString()) || string.IsNullOrWhiteSpace(assetemployeeVM.ReturnDate.ToString()) || string.IsNullOrWhiteSpace(assetemployeeVM.Quantity.ToString()) || string.IsNullOrWhiteSpace(assetemployeeVM.ActionId.ToString()) || string.IsNullOrWhiteSpace(assetemployeeVM.AssetId.ToString()) || string.IsNullOrWhiteSpace(assetemployeeVM.EmployeeId.ToString()))
            {
                return status;
            }
            else
            {
                var result = _assetEmployeeRepository.Insert(assetemployeeVM);
                return result;
            }
        }

        public bool Update(int id, AssetEmployeeVM assetemployeeVM)
        {
            if(string.IsNullOrWhiteSpace(id.ToString()) || string.IsNullOrWhiteSpace(assetemployeeVM.LoanDate.ToString()) || string.IsNullOrWhiteSpace(assetemployeeVM.ReturnDate.ToString()) || string.IsNullOrWhiteSpace(assetemployeeVM.Quantity.ToString()) || string.IsNullOrWhiteSpace(assetemployeeVM.ActionId.ToString()) || string.IsNullOrWhiteSpace(assetemployeeVM.AssetId.ToString()) || string.IsNullOrWhiteSpace(assetemployeeVM.EmployeeId.ToString()))
            {
                return status;
            }
            else
            {
                var result = _assetEmployeeRepository.Update(id, assetemployeeVM);
                return result;
            }
        }
    }
}

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
    public class SupplierService : ISupplierService
    {
        bool status = false;
        private readonly ISupplierRepository _supplierRepository;
        public SupplierService(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }
        public SupplierService() { }
        public bool Delete(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                return status;
            }
            else
            {
                var result = _supplierRepository.Delete(id);
                return result;
            }
        }

        public List<Supplier> Get()
        {
            var result = _supplierRepository.Get();
            return result;
        }

        public Supplier Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _supplierRepository.Get(id);
                return result;
            }
        }

        public bool Insert(SupplierVM supplierVM)
        {
            if (string.IsNullOrWhiteSpace(supplierVM.Name) || string.IsNullOrWhiteSpace(supplierVM.Company) || string.IsNullOrWhiteSpace(supplierVM.Phone) || string.IsNullOrWhiteSpace(supplierVM.Email))
            {
                return status;
            }
            else
            {
                var result = _supplierRepository.Insert(supplierVM);
                return result;
            }
        }

        public bool Update(int id, SupplierVM supplierVM)
        {
            if (string.IsNullOrWhiteSpace(supplierVM.Name) || string.IsNullOrWhiteSpace(supplierVM.Company) || string.IsNullOrWhiteSpace(supplierVM.Phone) || string.IsNullOrWhiteSpace(supplierVM.Email))
            {
                return status;
            }
            else
            {
                var result = _supplierRepository.Update(id, supplierVM);
                return result;
            }
        }
    }
}

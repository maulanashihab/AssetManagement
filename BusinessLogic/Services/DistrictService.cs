using BusinessLogic.Services.Interfaces;
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
    public class DistrictService : IDistrictService
    {
        bool status = false;
        private readonly IDistrictRepository _districtRepository;
        public DistrictService( IDistrictRepository districtRepository)
        {
            _districtRepository = districtRepository;
        }
        public DistrictService() { }
        public List<District> Get()
        {
            var result = _districtRepository.Get();
            return result;
        }

        public District Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                return null;
            }else
            {
                var result = _districtRepository.Get(id);
                return result;
            }
        }

        public bool Insert(DistrictVM districtVM)
        {
            if(string.IsNullOrWhiteSpace(districtVM.Name) || string.IsNullOrWhiteSpace(districtVM.RegencyId.ToString())){
                return status;
            }else
            {
                var result = _districtRepository.Insert(districtVM);
                return result;
            }
        }
    }
}

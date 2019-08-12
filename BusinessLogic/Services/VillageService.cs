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
    public class VillageService : IVillageService
    {
        bool status = false;
        private readonly IVillageRepository _villageRepository;
        public VillageService(IVillageRepository villageRepository)
        {
            _villageRepository = villageRepository;
        }
        public List<Village> Get()
        {
            var result = _villageRepository.Get();
            return result;
        }

        public Village Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("Data Not Found");
            }else
            {
                var result = _villageRepository.Get(id);
                return result;
            }
        }

        public bool Insert(VillageVM villageVM)
        {
            if(string.IsNullOrWhiteSpace(villageVM.Name) || string.IsNullOrWhiteSpace(villageVM.DistrictId.ToString()))
            {
                return status;
            }else
            {
                var result = _villageRepository.Insert(villageVM);
                return result;
            }
        }
    }
}

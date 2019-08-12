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
    public class ReligionService : IReligionService
    {
        bool status = false;
        private readonly IReligionRepository _religionRepository;
        public ReligionService(IReligionRepository religionRepository)
        {
            _religionRepository = religionRepository;
        }
        public List<Religion> Get()
        {
            var result = _religionRepository.Get();
            return result;
        }

        public Religion Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _religionRepository.Get(id);
                return result;
            }
        }

        public bool Insert(ReligionVM religionVM)
        {
            if (string.IsNullOrWhiteSpace(religionVM.Name))
            {
                return status;
            }else
            {
                var result = _religionRepository.Insert(religionVM);
                return result;
            }
        }
    }
}

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
    public class RegencyService : IRegencyService
    {
        bool status = false;
        private readonly IRegencyRepository _regencyRepository;
        public RegencyService(IRegencyRepository regencyRepository)
        {
            _regencyRepository = regencyRepository;
        }
        public RegencyService() { }
        public List<Regency> Get()
        {
            var result = _regencyRepository.Get();
            return result;
        }

        public Regency Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }else
            {
                var result = _regencyRepository.Get(id);
                return result;
            }
        }

        public bool Insert(RegencyVM regencyVM)
        {
            if(string.IsNullOrWhiteSpace(regencyVM.Name) || string.IsNullOrWhiteSpace(regencyVM.ProvinceId.ToString()))
            {
                return status;
            }else
            {
                var result = _regencyRepository.Insert(regencyVM);
                return result;
            }
        }
    }
}

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
    public class DivisionService : IDivisionService
    {
        bool status = false;
        private readonly IDivisionRepository _divisionRepository;
        public DivisionService(IDivisionRepository divisionRepository)
        {
            _divisionRepository = divisionRepository;
        }
        public List<Division> Get()
        {
            var result = _divisionRepository.Get();
            return result;
        }

        public Division Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                return null;
            }else
            {
                var result = _divisionRepository.Get(id);
                return result;
            }
        }

        public bool Insert(DivisionVM divisionVM)
        {
            if (string.IsNullOrWhiteSpace(divisionVM.Name))
            {
                return status;
            }else
            {
                var result = _divisionRepository.Insert(divisionVM);
                return result;
            }
        }
    }
}

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
    public class RoleService : IRoleService
    {
        bool status = false;
        private readonly IRoleRepository _roleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public List<Role> Get()
        {
            var result = _roleRepository.Get();
            return result;
        }

        public Role Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("No Data Found");
            }
            else
            {
                var result = _roleRepository.Get(id);
                return result;
            }
        }

        public bool Insert(RoleVM roleVM)
        {
            if (string.IsNullOrWhiteSpace(roleVM.Name))
            {
                return status;
            }
            else
            {
                var result = _roleRepository.Insert(roleVM);
                return result;
            }
        }
    }        
}
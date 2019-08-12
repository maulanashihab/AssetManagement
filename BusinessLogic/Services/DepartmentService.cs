using BusinessLogic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using DataAccess.ViewModels;
using Common.Repositories;
using Common.Repositories.Interfaces;

namespace BusinessLogic.Services
{
    public class DepartmentService : IDepartmentService
    {
        bool status = false;
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public DepartmentService() { }
        public List<Department> Get()
        {
            var result = _departmentRepository.Get();
            return result;
        }
        
        public Department Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                return null;
            }else
            {
                var result = _departmentRepository.Get(id);
                return result;
            }
        }

        public bool Insert(DepartmentVM departmentVM)
        {
            if (string.IsNullOrWhiteSpace(departmentVM.Name) || string.IsNullOrWhiteSpace(departmentVM.DivisionId.ToString()))
            {
                return status;
            }
            else
            {
                var result = _departmentRepository.Insert(departmentVM);
                return result;
            }
        }
    }
}

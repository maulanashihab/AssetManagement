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
    public class EmployeeService : IEmployeeService
    {
        bool status = false;
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public List<Employee> Get()
        {
            var result = _employeeRepository.Get();
            return result;
        }

        public Employee Get(int id)
        {
            if (string.IsNullOrWhiteSpace(id.ToString()))
            {
                throw new ArgumentOutOfRangeException("Data Not Found");
            }
            else
            {
                var result = _employeeRepository.Get(id);
                return result;
            }
        }

        //public Employee GetLast()
        //{
        //    throw new NotImplementedException();
        //}

        public bool Insert(EmployeeVM employeeVM)
        {
            if (string.IsNullOrWhiteSpace(employeeVM.FirstName) || string.IsNullOrWhiteSpace(employeeVM.LastName) || string.IsNullOrWhiteSpace(employeeVM.Address) || string.IsNullOrWhiteSpace(employeeVM.Gender.ToString()) || string.IsNullOrWhiteSpace(employeeVM.MaritalStatus.ToString()) || string.IsNullOrWhiteSpace(employeeVM.NumberofChildren.ToString()) || string.IsNullOrWhiteSpace(employeeVM.PhoneNumber) || string.IsNullOrWhiteSpace(employeeVM.Email) || string.IsNullOrWhiteSpace(employeeVM.Salary.ToString()) || string.IsNullOrWhiteSpace(employeeVM.ReligionId.ToString()) || string.IsNullOrWhiteSpace(employeeVM.DepartmentId.ToString()) || string.IsNullOrWhiteSpace(employeeVM.RoleId.ToString()) || string.IsNullOrWhiteSpace(employeeVM.VillageId.ToString()) || string.IsNullOrWhiteSpace(employeeVM.ManagerId.ToString()))
            {
                return status;
            }else
            {
                var result = _employeeRepository.Insert(employeeVM);
                return result;
            }
        }
    }
}

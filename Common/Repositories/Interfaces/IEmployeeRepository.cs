using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employee> Get();
        Employee Get(int id);
        Employee GetLast();
        List<Employee> Get(string value);
        bool Insert(EmployeeVM employeeVM);
        //bool Update(int id, EmployeeVM employeeVM);
        //bool Delete(int id);
    }
}

using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> Get();
        Employee Get(int id);
        //Employee GetLast();
        //List<Employee> Get(string value);
        bool Insert(EmployeeVM employeeVM);
        //bool Update(int id, EmployeeVM employeeVM);
        //bool Delete(int id);
    }
}

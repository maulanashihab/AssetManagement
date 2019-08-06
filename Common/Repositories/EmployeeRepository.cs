using Common.Repositories.Interfaces;
using DataAccess.Context;
using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private bool status = false;
        private ApplicationContext applicationContext = new ApplicationContext();

        //public bool Delete(int id)
        //{
        //    var get = Get(id);
        //    get.Delete();
        //    applicationContext.Entry(get).State = EntityState.Modified;
        //    var result = applicationContext.SaveChanges();
        //    return result > 0;
        //}

        public List<Employee> Get()
        {
            var get = applicationContext.Employees.Include("TB_M_Religion").Include("TB_M_Role").Include("TB_M_Village").Include("TB_M_Department").Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Employee GetLast()
        {
            var get = applicationContext.Employees.OrderByDescending(t => t.Id).FirstOrDefault();
            return get;
        }

        public List<Employee> Get(string value)
        {
            //roles di application context class
            var get = applicationContext.Employees.Include("TB_M_Religion").Include("TB_M_Role").Include("TB_M_Village").Include("TB_M_Department").Where(x => (x.FirstName.Contains(value) || x.FirstName.Contains(value) || x.Id.ToString().Contains(value) || x.Religion.Name.Contains(value)) && x.IsDelete == false).ToList();
            return get;
        }

        public Employee Get(int id)
        {
            var get = applicationContext.Employees.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(EmployeeVM employeeVM)
        {
            var push = new Employee(employeeVM);
            var getManager = applicationContext.Employees.SingleOrDefault(x => x.IsDelete == false && x.Id == employeeVM.ManagerId);
            var getReligion = applicationContext.Religions.SingleOrDefault(x => x.IsDelete == false && x.Id == employeeVM.ReligionId);
            var getRole = applicationContext.Roles.SingleOrDefault(x => x.IsDelete == false && x.Id == employeeVM.RoleId);
            var getVillage = applicationContext.Villages.SingleOrDefault(x => x.IsDelete == false && x.Id == employeeVM.VillageId);
            var getDepartment = applicationContext.Departments.SingleOrDefault(x => x.IsDelete == false && x.Id == employeeVM.DepartmentId);
            push.Manager = getManager;
            push.Religion = getReligion;
            push.Role = getRole;
            push.Village = getVillage;
            push.Department = getDepartment;
            applicationContext.Employees.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        //public bool Update(int id, EmployeeVM employeeVM)
        //{
        //    var get = Get(id);
        //    var getManager = applicationContext.Employee.SingleOrDefault(x => x.IsDeleted == false && x.Id == employeeVM.ManagerId);
        //    var getReligion = applicationContext.Religion.SingleOrDefault(x => x.IsDeleted == false && x.Id == employeeVM.ReligionId);
        //    var getRole = applicationContext.Role.SingleOrDefault(x => x.IsDeleted == false && x.Id == employeeVM.RoleId);
        //    var getVillage = applicationContext.Village.SingleOrDefault(x => x.IsDeleted == false && x.Id == employeeVM.VillageId);
        //    var getDepartment = applicationContext.Department.SingleOrDefault(x => x.IsDeleted == false && x.Id == employeeVM.DepartmentId);
        //    get.Manager = getManager;
        //    get.Religion = getReligion;
        //    get.Role = getRole;
        //    get.Village = getVillage;
        //    get.Department = getDepartment;
        //    get.Update(employeeVM);
        //    applicationContext.Entry(get).State = EntityState.Modified;
        //    var result = applicationContext.SaveChanges();
        //    return result > 0;
        //}
    }
}

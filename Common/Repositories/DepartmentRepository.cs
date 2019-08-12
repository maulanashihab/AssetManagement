using Common.Repositories.Interfaces;
using DataAccess.Context;
using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Common.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
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

        public List<Department> Get()
        {
            var get = applicationContext.Departments.Include("Division").Where(x => x.IsDelete == false).ToList();
            return get;
        }

        //public List<Department> Get(string value)
        //{
        //    //roles di application context class
        //    var get = applicationContext.Departments.Include("TB_M_Division").Where(x => (x.Name.Contains(value) || x.Id.ToString().Contains(value) || x.Division.Name.Contains(value)) && x.IsDelete == false).ToList();
        //    return get;
        //}

        public Department Get(int id)
        {
            var get = applicationContext.Departments.SingleOrDefault(x => x.IsDelete == false && x.Id == id);
            return get;
        }

        public bool Insert(DepartmentVM departmentVM)
        {
            var push = new Department(departmentVM);
            //ini nih foreign key
            var getDivision = applicationContext.Divisions.SingleOrDefault(x => x.IsDelete == false && x.Id == departmentVM.DivisionId);
            push.Division = getDivision;
            applicationContext.Departments.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        //public bool Update(int id, DepartmentVM departmentVM)
        //{
        //    var get = Get(id);
        //    var getDivision = applicationContext.Division.SingleOrDefault(x => x.IsDeleted == false && x.Id == departmentVM.DivisionId);
        //    get.Division = getDivision;
        //    get.Update(departmentVM);
        //    applicationContext.Entry(get).State = EntityState.Modified;
        //    var result = applicationContext.SaveChanges();
        //    return result > 0;
        //}
    }
}

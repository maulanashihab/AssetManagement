using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public bool Gender { get; set; }
        public bool MaritalStatus { get; set; }
        public int NumberofChildren { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }
        public int ReligionId { get; set; }
        public int DepartmentId { get; set; }
        public int RoleId { get; set; }
        public int VillageId { get; set; }
        public int ManagerId { get; set; }
        public EmployeeVM() { }
        public EmployeeVM(string firstName, string lastName, string address, bool gender, bool maritalStatus, int numberofchildren, string phonenumber, string email, int salary, int religionid, int departmentid, int roleid, int villageid, int managerId)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Gender = gender;
            this.MaritalStatus = maritalStatus;
            this.NumberofChildren = numberofchildren;
            this.PhoneNumber = phonenumber;
            this.Email = email;
            this.Salary = salary;
            this.ReligionId = religionid;
            this.DepartmentId = departmentid;
            this.RoleId = roleid;
            this.VillageId = villageid;
            this.ManagerId = managerId;
        }
    }
}

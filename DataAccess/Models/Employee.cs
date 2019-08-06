using Core.Base;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_M_Employee")]
    public class Employee : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public bool Gender { get; set; }
        public bool MaritalStatus { get; set; }
        public int NumberofChildren { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }

        [ForeignKey("TB_M_Religion")]
        public int Religion_Id { get; set; }
        public Religion Religion { get; set; }

        [ForeignKey("TB_M_Department")]
        public int Department_Id { get; set; }
        public Department Department { get; set; }

        [ForeignKey("TB_M_Village")]
        public int Village_Id { get; set; }
        public Village Village { get; set; }

        [ForeignKey("TB_M_Role")]
        public int Role_Id { get; set; }
        public Role Role { get; set; }

        public Employee Manager { get; set; }
        public Employee() { }
        public Employee(EmployeeVM employeeVM)
        {
            this.FirstName = employeeVM.FirstName;
            this.LastName = employeeVM.LastName;
            this.Address = employeeVM.Address;
            this.Gender = employeeVM.Gender;
            this.MaritalStatus = employeeVM.MaritalStatus;
            this.NumberofChildren = employeeVM.NumberofChildren;
            this.PhoneNumber = employeeVM.PhoneNumber;
            this.Email = employeeVM.Email;
            this.Salary = employeeVM.Salary;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
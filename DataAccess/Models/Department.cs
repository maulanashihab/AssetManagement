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
    [Table("TB_M_Department")]
    public class Department : BaseModel
    {
        public string Name { get; set; }

        [ForeignKey("TB_M_Division")]
        public int Division_Id { get; set; }
        public Division Division { get; set; }
        public Department() { }
        public Department (DepartmentVM departmentVM)
        {
            this.Name = departmentVM.Name;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
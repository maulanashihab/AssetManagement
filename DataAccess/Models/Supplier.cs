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
    [Table("TB_M_Supplier")]
    public class Supplier : BaseModel
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        //parsing
        public Supplier() { }
        public Supplier(SupplierVM supplierVM)
        {
            this.Name = supplierVM.Name;
            this.Company = supplierVM.Company;
            this.Phone = supplierVM.Phone;
            this.Email = supplierVM.Email;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Update(SupplierVM supplierVM)
        {
            this.Name = supplierVM.Name;
            this.Company = supplierVM.Company;
            this.Phone = supplierVM.Phone;
            this.Email = supplierVM.Email;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
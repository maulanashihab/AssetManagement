using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class SupplierVM
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public SupplierVM() { }
        public SupplierVM(string Name, string Company, string Phone, string Email)
        {
            this.Name = Name;
            this.Company = Company;
            this.Phone = Phone;
            this.Phone = Email;
        }
        public void Update(string Name, string Company, string Phone, string Email)
        {
            this.Name = Name;
            this.Company = Company;
            this.Phone = Phone;
            this.Phone = Email;
        }
    }
}
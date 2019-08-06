using Core.Base;
using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    [Table("TB_T_Asset_Employee")]
    public class AssetEmployee : BaseModel
    {
        public DateTime? LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int Quantity { get; set; }
        public Status Status { get; set; }
        public Employee Employee { get; set; }
        public Asset Asset { get; set; }
        //parsing
        public AssetEmployee() { }
        public AssetEmployee(AssetEmployeeVM assetemployeeVM)
        {
            this.LoanDate = assetemployeeVM.LoanDate;
            this.ReturnDate = assetemployeeVM.ReturnDate;
            this.Quantity = assetemployeeVM.Quantity;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Update(AssetEmployeeVM assetemployeeVM)
        {
            this.LoanDate = assetemployeeVM.LoanDate;
            this.ReturnDate = assetemployeeVM.ReturnDate;
            this.Quantity = assetemployeeVM.Quantity;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
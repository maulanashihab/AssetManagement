using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class AssetEmployeeVM
    {
        public DateTime? LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int Quantity { get; set; }
        public int ActionId { get; set; }
        public int EmployeeId { get; set; }
        public int AssetId { get; set; }
        public AssetEmployeeVM() { }
        public AssetEmployeeVM(DateTime? loandate, DateTime? returndate, int quantity, int actionid, int employeeid, int assetid)
        {
            this.LoanDate = loandate;
            this.ReturnDate = returndate;
            this.Quantity = quantity;
            this.ActionId = actionid;
            this.EmployeeId = employeeid;
            this.AssetId = assetid;
        }
        public void Update(DateTime? loandate, DateTime? returndate, int quantity, int actionid, int employeeid, int assetid)
        {
            this.LoanDate = loandate;
            this.ReturnDate = returndate;
            this.Quantity = quantity;
            this.ActionId = actionid;
            this.EmployeeId = employeeid;
            this.AssetId = assetid;
        }
    }
}

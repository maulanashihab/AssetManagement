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
    [Table("TB_M_Status")]
    public class Status : BaseModel
    {
        public string Name { get; set; }
        //parsing
        public Status() { }
        public Status(StatusVM statusVM)
        {
            this.Name = statusVM.Name;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Update(StatusVM statusVM)
        {
            this.Name = statusVM.Name;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
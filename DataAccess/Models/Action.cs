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
    [Table("TB_M_Actions")]
    public class Action : BaseModel
    {
        public string Name { get; set; }
        //parsing
        public Action() { }
        public Action(ActionVM actionVM)
        {
            this.Name = actionVM.Name;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Update(ActionVM actionVM)
        {
            this.Name = actionVM.Name;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
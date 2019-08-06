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
    [Table("TB_M_Category")]
    public class Category : BaseModel
    {
        public string Name { get; set; }
        //parsing
        public Category() { }
        public Category(CategoryVM categoryVM)
        {
            this.Name = categoryVM.Name;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Update(CategoryVM categoryVM)
        {
            this.Name = categoryVM.Name;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
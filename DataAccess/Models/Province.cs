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
    [Table("TB_M_Province")]
    public class Province : BaseModel
    {
        public string Name { get; set; }
        public Province() { }
        public Province(ProvinceVM ProvinceVM)
        {
            this.Name = ProvinceVM.Name;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}

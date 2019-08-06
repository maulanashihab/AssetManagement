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
    [Table("TB_M_Division")]
    public class Division : BaseModel
    {
        public string Name { get; set; }
        public Division() { }
        public Division(DivisionVM divisionVM)
        {
            this.Name = divisionVM.Name;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }

    }
}
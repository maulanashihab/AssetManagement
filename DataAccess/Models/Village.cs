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
    [Table("TB_M_Village")]
    public class Village : BaseModel
    {
        public string Name { get; set; }
        [ForeignKey("TB_M_District")]
        public int District_Id { get; set; }
        public District District { get; set; }
        public Village() { }
        public Village(VillageVM villageVM)
        {
            this.Name = villageVM.Name;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
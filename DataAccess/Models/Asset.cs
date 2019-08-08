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
    [Table("TB_M_Asset")]
    //test
    public class Asset : BaseModel
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public int SerialKey { get; set; }
        public string Spesification { get; set; }
        public Supplier Supplier { get; set; }
        public Category Category { get; set; }
        //parsing
        public Asset() { }
        public Asset(AssetVM assetVM)
        {
            this.Name = assetVM.Name;
            this.Stock = assetVM.Stock;
            this.SerialKey = assetVM.SerialKey;
            this.Spesification = assetVM.Spesification;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Update(AssetVM assetVM)
        {
            this.Name = assetVM.Name;
            this.Stock = assetVM.Stock;
            this.SerialKey = assetVM.SerialKey;
            this.Spesification = assetVM.Spesification;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }
        public void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
        }
    }
}
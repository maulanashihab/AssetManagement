using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class RegencyVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProvinceId { get; set; }
        public RegencyVM() { }
        public RegencyVM(string name, int provinceId)
        {
            this.Name = name;
            this.ProvinceId = provinceId;
        }
    }
}

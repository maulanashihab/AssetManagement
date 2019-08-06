using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class ProvinceVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProvinceVM() { }
        public ProvinceVM(string name)
        {
            this.Name = name;
        }
    }
}

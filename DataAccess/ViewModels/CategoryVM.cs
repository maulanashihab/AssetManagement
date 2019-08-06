using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class CategoryVM
    {
        public string Name { get; set; }
        public CategoryVM() { }
        public CategoryVM(string name)
        {
            this.Name = name;
        }
        public void Update(string name)
        {
            this.Name = name;
        }
    }
}
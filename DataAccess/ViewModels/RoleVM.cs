using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    
    public class RoleVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RoleVM() { }
        public RoleVM(string name)
        {
            this.Name = name;
        }

    }
}

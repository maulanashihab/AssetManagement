using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class ActionVM
    {
        public string Name { get; set; }
        public ActionVM() { }
        public ActionVM(string name)
        {
            this.Name = name;
        }
        public void Update(string name)
        {
            this.Name = name;
        }
    }
}

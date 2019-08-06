using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class StatusVM
    {
        public string Name { get; set; }
        public StatusVM() { }
        public StatusVM(string name)
        {
            this.Name = name;
        }
        public void Update(string name)
        {
            this.Name = name;
        }
    }
}

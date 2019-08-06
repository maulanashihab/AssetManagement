using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class DistrictVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegencyId { get; set; }
        public DistrictVM() { }
        public DistrictVM(string name, int regencyId)
        {
            this.Name = name;
            this.RegencyId = regencyId;
        }
    }
}

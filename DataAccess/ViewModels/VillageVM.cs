using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class VillageVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DistrictId { get; set; }
        public VillageVM() { }
        public VillageVM(string name, int districtId)
        {
            this.Name = name;
            this.DistrictId = districtId;
        }
    }
}

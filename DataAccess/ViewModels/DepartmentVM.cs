using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class DepartmentVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DivisionId { get; set; }
        public DepartmentVM() { }
        public DepartmentVM(string name, int divisionId)
        {
            this.Name = name;
            this.DivisionId = divisionId;
        }
    }
}

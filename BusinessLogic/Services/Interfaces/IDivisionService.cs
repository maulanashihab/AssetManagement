using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Interfaces
{
    public interface IDivisionService
    {
        List<Division> Get();
        Division Get(int id);
        //List<Division> Get(string value);
        bool Insert(DivisionVM divisionVM);
        //bool Update(int id, DivisionVM divisionVM);
        //bool Delete(int id);
    }
}

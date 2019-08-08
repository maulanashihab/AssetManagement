using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Interfaces
{
    public interface IReligionService
    {
        List<Religion> Get();
        Religion Get(int id);
        //List<Religion> Get(string value);
        bool Insert(ReligionVM religionVM);
        //bool Update(int id, ReligionVM religionVM);
        //bool Delete(int id);
    }
}

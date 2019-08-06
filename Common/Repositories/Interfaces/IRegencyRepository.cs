using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories.Interfaces
{
    public interface IRegencyRepository
    {
        List<Regency> Get();
        Regency Get(int id);
        List<Regency> Get(string value);
        bool Insert(RegencyVM regencyVM);
        //bool Update(int id, RegencyVM regencyVM);
        //bool Delete(int id);
    }
}

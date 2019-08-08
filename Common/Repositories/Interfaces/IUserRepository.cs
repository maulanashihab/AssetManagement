using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories.Interfaces
{
    public interface IUserRepository
    {
        List<User> Get();
        User Get(int id);
        bool Insert(UserVM userVM);
        //bool Update(int id, UserVM userVM);
        //bool Delete(int id);
    }
}

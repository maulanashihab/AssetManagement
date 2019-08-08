using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services.Interfaces
{
    public interface IRoleService
    {
        List<Role> Get();
        Role Get(int id);
        //List<Role> Get(string value);
        bool Insert(RoleVM roleVM);
        //bool Update(int id, RoleVM roleVM);
        //bool Delete(int id);
    }
}

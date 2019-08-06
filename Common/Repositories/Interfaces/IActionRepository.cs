using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories.Interfaces
{
    public interface IActionRepository
    {
        List<DataAccess.Models.Action> Get();
        DataAccess.Models.Action Get(int id);
        List<DataAccess.Models.Action> Get(string value);
        bool Insert(ActionVM actionVM);
        bool Update(int id, ActionVM actionVM);
        bool Delete(int id);
    }
}

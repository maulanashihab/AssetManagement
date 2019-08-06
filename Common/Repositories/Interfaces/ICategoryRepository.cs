using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> Get();
        Category Get(int id);
        List<Category> Get(string value);
        bool Insert(CategoryVM categoryVM);
        bool Update(int id, CategoryVM assetVM);
        bool Delete(int id);
    }
}

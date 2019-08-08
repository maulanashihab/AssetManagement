using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusineesLogic.Services.Interfaces
{
    public interface ISupplierService
    {
        List<Supplier> Get();
        Supplier Get(int id);
//        List<Supplier> Get(string value);
        bool Insert(SupplierVM SupplierVM);
        bool Update(int id, SupplierVM SupplierVM);
        bool Delete(int id);
    }
}

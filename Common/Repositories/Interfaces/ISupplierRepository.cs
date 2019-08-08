﻿using DataAccess.Models;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories.Interfaces
{
    public interface ISupplierRepository
    {
        List<Supplier> Get();
        Supplier Get(int id);
        bool Insert(SupplierVM SupplierVM);
        bool Update(int id, SupplierVM SupplierVM);
        bool Delete(int id);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class DivisionVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DivisionVM() { }
        public DivisionVM(string name)
        {
            this.Name = name;
        }
    }
}

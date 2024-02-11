﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Views.Interface
{
    public interface ICategory
    {
         int ID { get; set; }
        int row { get; set; }
        string CatName { get; set; }
         object dGVCat { get; set; }
        object btnAdd { get; set; }
        object btnNew { get; set; }
        object btnSave { get; set; }
        object btnDelete { get; set; }
        object btnDeleteAll { get; set; }
    }
}

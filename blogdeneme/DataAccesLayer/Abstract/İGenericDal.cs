﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface İGenericDal<T>where T : class
    {
        void İnsert(T t);
        void Update(T t);
        void Delete(T t);   

        List<T> GetList();
        T GetByID(int id);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloper.DataAccess
{
    public interface IDataAccess<T>
    {
        List<T> GetList();
        int Add(T entity);
        int Delete(T entity);
        int update(T entity);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.repository
{
    public interface Irepository<T> where T : class
    {
        ICollection<T> GetAll();


        T Get(int id);


        T Find(Expression<Func<T, bool>> match);



        ICollection<T> FindAll(Expression<Func<T, bool>> match);



        T Add(T t);



        T Update(T updated, int key);
        T Update(T item);


        void Delete(T t);
    }
}

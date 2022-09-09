﻿using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //class ola bilir demek deyil referans tip verile biler demekdir (where T:class)
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter=null);

        T Get(Expression<Func<T, bool>> filter);
        
        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}

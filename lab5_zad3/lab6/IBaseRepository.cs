using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Interfaces
{
    interface IBaseRepository<T, TEntity> where T : IEntity<TEntity>
    {
        T Get(TEntity id);
        void Create(T item);
        void Upadte(T item);
        void Delete(TEntity id);
        List<T> GetAll();
    }
}

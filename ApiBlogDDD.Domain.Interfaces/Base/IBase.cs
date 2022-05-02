using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApiBlogDDD.Domain.Interfaces.Base
{
    public interface IBase<TEntity> where TEntity : class
    {
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetBy(Expression<Func<TEntity, bool>> expression);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(Guid id);
        void Dispose();
    }
}

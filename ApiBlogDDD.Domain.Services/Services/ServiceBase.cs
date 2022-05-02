using ApiBlogDDD.Domain.Interfaces.Base;
using ApiBlogDDD.Domain.Interfaces.Repositories;
using ApiBlogDDD.Domain.Interfaces.Repositories.Dapper;
using ApiBlogDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApiBlogDDD.Domain.Services.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _applicationBase;

        public ServiceBase(IRepositoryBase<TEntity> applicationBase)
        {
            _applicationBase = applicationBase;
        }

        public TEntity GetById(Guid id) => _applicationBase.GetById(id);

        public IEnumerable<TEntity> GetAll() => _applicationBase.GetAll();

        public IEnumerable<TEntity> GetBy(Expression<Func<TEntity, bool>> expression) => _applicationBase.GetBy(expression);

        public void Add(TEntity entity) => _applicationBase.Add(entity);

        public void Update(TEntity entity) => _applicationBase.Update(entity);

        public void Remove(Guid id) => _applicationBase.Remove(id);

        public void Dispose() => _applicationBase.Dispose();
    }
}

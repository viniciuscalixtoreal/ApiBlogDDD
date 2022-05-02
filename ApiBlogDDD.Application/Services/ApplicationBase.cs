using ApiBlogDDD.Application.Interfaces;
using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Repositories;
using ApiBlogDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ApiBlogDDD.Application.Services
{
    public class ApplicationBase<TEntity> : IApplicationBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;
        private IRepositoryBase<User> applicationBase;

        public ApplicationBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public ApplicationBase(IRepositoryBase<User> applicationBase)
        {
            this.applicationBase = applicationBase;
        }

        public TEntity GetById(Guid id) => _serviceBase.GetById(id);
        public IEnumerable<TEntity> GetAll() => _serviceBase.GetAll();
        public IEnumerable<TEntity> GetBy(Expression<Func<TEntity, bool>> expression) => _serviceBase.GetBy(expression);
        public void Add(TEntity entity) => _serviceBase.Add(entity);
        public void Update(TEntity entity) => _serviceBase.Update(entity);
        public void Remove(Guid id) => _serviceBase.Remove(id);
        public void Dispose() => _serviceBase.Dispose();
    }
}

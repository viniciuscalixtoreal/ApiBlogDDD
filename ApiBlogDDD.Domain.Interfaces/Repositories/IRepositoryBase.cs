using ApiBlogDDD.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> : IBase<TEntity> where TEntity : class
    {
    }
}

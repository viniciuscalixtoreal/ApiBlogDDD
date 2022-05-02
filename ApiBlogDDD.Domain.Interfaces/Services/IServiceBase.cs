using ApiBlogDDD.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> : IBase<TEntity> where TEntity : class
    {
    }
}

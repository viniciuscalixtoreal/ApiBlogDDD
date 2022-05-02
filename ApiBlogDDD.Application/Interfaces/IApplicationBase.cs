using ApiBlogDDD.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Application.Interfaces
{
    public interface IApplicationBase<TEntity> : IBase<TEntity> where TEntity : class
    {
    }
}

using ApiBlogDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Interfaces.Services
{
    public interface IGeoService : IServiceBase<Geo>
    {
        IEnumerable<Geo> GetAll();
        void AddGeo(Geo geo);
    }
}

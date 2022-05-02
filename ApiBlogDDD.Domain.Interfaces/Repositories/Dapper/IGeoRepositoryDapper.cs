using ApiBlogDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Interfaces.Repositories.Dapper
{
    public interface IGeoRepositoryDapper //: IRepositoryBase<Geo>
    {
        IEnumerable<Geo> GetAll();
        int AddGeo(Geo geo);
    }
}

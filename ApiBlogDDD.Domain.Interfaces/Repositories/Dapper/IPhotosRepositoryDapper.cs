using ApiBlogDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Interfaces.Repositories.Dapper
{
    public interface IPhotosRepositoryDapper //: IRepositoryBase<Photos>
    {
        IEnumerable<Photos> GetAll();
        void AddPhotos(Photos obj);
    }
}

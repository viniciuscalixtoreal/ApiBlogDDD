using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Base;
using ApiBlogDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Interfaces.Repositories.Dapper
{
    public interface IAlbumRepositoryDapper //: IRepositoryBase<Albums>
    {
        IEnumerable<Albums> GetAll();
        void AddAlbum(Albums obj);
    }
}

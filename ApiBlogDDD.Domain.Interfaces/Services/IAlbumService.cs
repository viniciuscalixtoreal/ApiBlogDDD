using ApiBlogDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Interfaces.Services
{
    public interface IAlbumService 
    {
        IEnumerable<Albums> GetAll();
        void AddAlbum(Albums albums);
    }
}

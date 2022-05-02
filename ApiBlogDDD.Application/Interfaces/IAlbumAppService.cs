using ApiBlogDDD.Application.ViewModels;
using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Application.Interfaces
{
    public interface IAlbumAppService 
    {
        IEnumerable<Albums> GetAll();
        void AddAlbum(Albums album);
    }
}

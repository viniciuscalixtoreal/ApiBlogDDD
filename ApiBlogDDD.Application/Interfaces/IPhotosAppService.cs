using ApiBlogDDD.Application.ViewModels;
using ApiBlogDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Application.Interfaces
{
    public interface IPhotosAppService 
    {
        IEnumerable<Photos> GetAll();
        void AddPhotos(Photos obj);
    }
}

using ApiBlogDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Interfaces.Services
{
    public interface IPhotosService 
    {
        IEnumerable<Photos> GetAll();
        void AddPhotos(Photos obj);
    }
}

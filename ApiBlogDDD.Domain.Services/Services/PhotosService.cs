using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Repositories;
using ApiBlogDDD.Domain.Interfaces.Repositories.Dapper;
using ApiBlogDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Services.Services
{
    public class PhotosService : IPhotosService
    {
        private readonly IPhotosRepositoryDapper _photosRepository;

        public PhotosService(IPhotosRepositoryDapper photosRepository) 
        {
            _photosRepository = photosRepository;
        }

        public IEnumerable<Photos> GetAll() => _photosRepository.GetAll();

        public void AddPhotos(Photos obj) => _photosRepository.AddPhotos(obj);
    }
}

using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Base;
using ApiBlogDDD.Domain.Interfaces.Repositories;
using ApiBlogDDD.Domain.Interfaces.Repositories.Dapper;
using ApiBlogDDD.Domain.Interfaces.Services;
using ApiBlogDDD.Infra.Data.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Services.Services
{
    public class AlbumsService : IAlbumService
    {
        private readonly IAlbumRepositoryDapper _albumsRepository;
        public AlbumsService(IAlbumRepositoryDapper albumRepository) 
        {
            _albumsRepository = albumRepository;
        }

        public IEnumerable<Albums> GetAll() => _albumsRepository.GetAll();
        public void AddAlbum(Albums obj) => _albumsRepository.AddAlbum(obj);
    }
}

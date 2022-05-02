using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Repositories.Dapper;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace ApiBlogDDD.Infra.Data.Repository.Dapper
{
    public class PhotoRepositoryDapper : DapperRepository, IPhotosRepositoryDapper
    {
        private readonly IConfiguration _config;

        public PhotoRepositoryDapper(IConfiguration config) 
            : base(config.GetConnectionString("DefaultConnection"))
        {
            _config = config;
        }

        public IEnumerable<Photos> GetAll()
        {
            using var dbConnection = Connection;
            dbConnection.Open();

            return dbConnection.Query<Photos>("SELECT * FROM Photos WITH(NOLOCK)");
        }

        public void AddPhotos(Photos obj)
        {
            using var dbConnection = Connection;

            string sQuery = "INSERT INTO [PHOTOS] (AlbumId, Title, Url, ThumbnailUrl)"
                            + "VALUES(@AlbumId, @Title, @Url, @ThumbnailUrl)";

            dbConnection.Open();
            dbConnection.Execute(sQuery, obj);
        }

        public void Dispose() => GC.SuppressFinalize(this);
    }
}

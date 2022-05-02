using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Repositories.Dapper;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;

namespace ApiBlogDDD.Infra.Data.Repository.Dapper
{
    public class AlbumRepositoryDapper : DapperRepository, IAlbumRepositoryDapper, IDisposable
    {
        private readonly IConfiguration _config;
        public AlbumRepositoryDapper(IConfiguration config) 
            : base(config.GetConnectionString("DefaultConnection"))
        {
            _config = config;
        }

        public IEnumerable<Albums> GetAll()
        {
            using var dbConnection = Connection;
            dbConnection.Open();

            return dbConnection.Query<Albums>("SELECT * FROM Albums WITH(NOLOCK)");
        }

        public void AddAlbum(Albums obj)
        {
            using IDbConnection dbConnection = Connection;
            string sQuery = "INSERT INTO [Albums] (UserId, Title)"
                            + "VALUES(@UserId, @Title)";
            dbConnection.Open();
            dbConnection.Execute(sQuery, obj);
        }

        public void Dispose() => GC.SuppressFinalize(this);
    }
}

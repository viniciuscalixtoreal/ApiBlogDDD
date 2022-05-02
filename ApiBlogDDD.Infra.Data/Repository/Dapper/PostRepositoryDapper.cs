using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Repositories.Dapper;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace ApiBlogDDD.Infra.Data.Repository.Dapper
{
    public class PostRepositoryDapper : DapperRepository, IPostRepositoryDapper
    {
        private readonly IConfiguration _config;

        public PostRepositoryDapper(IConfiguration config) 
            : base(config.GetConnectionString("DefaultConnection"))
        {
            _config = config;
        }

        public IEnumerable<Post> GetAll()
        {
            using var dbConnection = Connection;
            dbConnection.Open();

            return dbConnection.Query<Post>("SELECT * FROM Post WITH(NOLOCK)");
        }

        public void AddPost(Post obj)
        {
            using var dbConnection = Connection;

            string sQuery = "INSERT INTO [Post] (UserId, Title, Body)"
                            + "VALUES (@UserId, @Title, @Body)";
            dbConnection.Open();
            dbConnection.Execute(sQuery, obj);
        }

        public void Dispose() => GC.SuppressFinalize(this);
    }
}

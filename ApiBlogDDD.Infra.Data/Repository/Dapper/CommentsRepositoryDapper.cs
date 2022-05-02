using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Repositories.Dapper;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace ApiBlogDDD.Infra.Data.Repository.Dapper
{
    public class CommentsRepositoryDapper : DapperRepository, ICommentsRepositoryDapper
    {
        private readonly IConfiguration _config;

        public CommentsRepositoryDapper(IConfiguration config) 
            : base(config.GetConnectionString("DefaultConnection"))
        {
            _config = config;
        }

        public IEnumerable<Comments> GetAll()
        {
            using var dbConnection = Connection;
            dbConnection.Open();

            return dbConnection.Query<Comments>("SELECT * FROM Comments WHITH(NOLOCK)");
        }

        public void AddComments(Comments obj)
        {
            using var dbConnection = Connection;

            string sQuery = "INSERT INTO [Comments] (PostId, Name, Email, Body)"
                + "VALUES(@PostId, @Name, @Email, @Body)";

            dbConnection.Open();
            dbConnection.Execute(sQuery, obj);
        }

        public void Dispose() => GC.SuppressFinalize(this);
     }
}

using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Repositories.Dapper;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ApiBlogDDD.Infra.Data.Repository.Dapper
{
    public class GeoRepositoryDapper : DapperRepository, IGeoRepositoryDapper
    {
        private readonly IConfiguration _config;

        public GeoRepositoryDapper(IConfiguration config) : base(config.GetConnectionString("DefaultConnection"))
        {
            _config = config;
        }

        public IEnumerable<Geo> GetAll()
        {
            using var dbConnection = Connection;
            dbConnection.Open();

            return dbConnection.Query<Geo>("SELECT * FROM Geo WITH(NOLOCK)").ToList();
        }

        public int AddGeo(Geo obj)
        {
            using IDbConnection dbConnection = Connection;

            string sQuery = "INSERT INTO [Geo] (Lat, Lng)"
                + "VALUES (@Lat, @Lng)";

            dbConnection.Open();
            return dbConnection.Execute(sQuery, obj);
        }
    }
}

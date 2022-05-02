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
    public class AddressRepositoryDapper : DapperRepository, IAddressRepositoryDapper
    {
        private readonly IConfiguration _config;
        private readonly IGeoRepositoryDapper _geoRepositoryDapper;
        public AddressRepositoryDapper(IConfiguration config, IGeoRepositoryDapper geoRepositoryDapper)
            : base(config.GetConnectionString("DefaultConnection"))
        {
            _config = config;
            _geoRepositoryDapper = geoRepositoryDapper;
        }

        public IEnumerable<Address> GetAll()
        {
            using var dbConnection = Connection;
            
            dbConnection.Open();

            return dbConnection.Query<Address>("SELECT * FROM Address WITH(NOLOCK)").ToList();
        }

        public int AddAddress(Address obj)
        {
            using IDbConnection dbConnection = Connection;
            dbConnection.Open();

            var geo = new Geo
            {
                Lat = obj.Geo.Lat,
                Lng = obj.Geo.Lng
            };

            int geoId = _geoRepositoryDapper.AddGeo(geo);

            string sQuery = @$"INSERT INTO [Address] (GeoId, Street, Suite, City, Zipcode)
                            VALUES({geoId}, @Street, @Suite, @City, @Zipcode)";

            int id = dbConnection.Execute(sQuery, obj);
            return id;
        }
    }
}

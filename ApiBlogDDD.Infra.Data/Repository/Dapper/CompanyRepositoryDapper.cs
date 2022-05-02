using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Repositories.Dapper;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ApiBlogDDD.Infra.Data.Repository.Dapper
{
    public class CompanyRepositoryDapper : DapperRepository, ICompanyRepositoryDapper
    {
        private readonly IConfiguration _config;

        public CompanyRepositoryDapper(IConfiguration config) : base(config.GetConnectionString("DefaultConnection"))
        {
            _config = config;
        }

        public IEnumerable<Company> GetAll()
        {
            using var dbConnection = Connection;
            dbConnection.Open();

            return dbConnection.Query<Company>("SELECT * FROM Company WITH(NOLOCK)");
        }

        public int AddCompany(Company obj)
        {
            using IDbConnection dbConnection = Connection;

            string sQuery = "INSERT INTO [Company] (CompanyName, CatchPhrase, BS)"
                + "VALUES(@Name, @CatchPhrase, @BS)";

            dbConnection.Open();
            return dbConnection.Execute(sQuery, obj);
        }
    }
}

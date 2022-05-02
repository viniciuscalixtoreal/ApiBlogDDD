using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ApiBlogDDD.Infra.Data.Repository.Dapper
{
    public class DapperRepository : IDisposable
    {
        protected string _connectionString;

        public DapperRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }
        }

        void IDisposable.Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

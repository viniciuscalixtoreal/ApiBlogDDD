using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Repositories.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiBlogDDD.Infra.Data.Repository.Dapper
{
    public class AuthenticateRepositoryDapper : IAuthenticateRepositoryDapper
    {
        public Authenticate GetUser(Authenticate obj)
        {
            var users = new List<Authenticate>
            {
                new Authenticate
                {
                    Id = 1,
                    Username = "frwk.teste",
                    Password = "frwk@123"
                }
            };

            return users.Where(x => x.Username.ToLower() == obj.Username.ToLower() && x.Password == obj.Password).FirstOrDefault();
        }
    }
}

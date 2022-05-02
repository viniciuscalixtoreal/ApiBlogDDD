using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Repositories;
using ApiBlogDDD.Domain.Interfaces.Repositories.Dapper;
using ApiBlogDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiBlogDDD.Domain.Services.Services
{
    public class AuthenticateService : ServiceBase<Authenticate>, IAuthenticateService
    {
        private readonly IAuthenticateRepositoryDapper _authenticateRepository;

        public AuthenticateService(IRepositoryBase<Authenticate> applicationBase) : base(applicationBase)
        {
            _authenticateRepository = (IAuthenticateRepositoryDapper)applicationBase;
        }

        public Authenticate GetUser(Authenticate aut)
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
            return users.Where(x => x.Username.ToLower() == aut.Username.ToLower() && x.Password == aut.Password).FirstOrDefault();
        }
    }
}

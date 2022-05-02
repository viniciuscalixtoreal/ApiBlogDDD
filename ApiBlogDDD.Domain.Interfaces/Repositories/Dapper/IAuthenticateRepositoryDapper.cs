using ApiBlogDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Interfaces.Repositories.Dapper
{
    public interface IAuthenticateRepositoryDapper //: IRepositoryBase<Authenticate>
    {
        Authenticate GetUser(Authenticate obj);
    }
}

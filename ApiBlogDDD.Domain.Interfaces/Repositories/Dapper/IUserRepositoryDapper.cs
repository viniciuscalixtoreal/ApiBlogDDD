using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Interfaces.Repositories.Dapper
{
    public interface IUserRepositoryDapper
    {
        IEnumerable<User> GetAll();
        void AddUser(User obj);
    }
}

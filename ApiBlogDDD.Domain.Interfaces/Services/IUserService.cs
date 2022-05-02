using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Interfaces.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        void AddUser(User user);
    }
}

using ApiBlogDDD.Application.DTO;
using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Application.Interfaces
{
    public interface IUserAppService
    {
        IEnumerable<User> GetAll();
        void AddUser(User obj);
    }
}

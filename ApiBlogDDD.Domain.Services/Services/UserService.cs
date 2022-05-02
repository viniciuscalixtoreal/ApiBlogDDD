using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Repositories;
using ApiBlogDDD.Domain.Interfaces.Repositories.Dapper;
using ApiBlogDDD.Domain.Interfaces.Services;
using ApiBlogDDD.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepositoryDapper _userRepository;

        public UserService(IUserRepositoryDapper userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetAll() => _userRepository.GetAll();

        public void AddUser(User obj) => _userRepository.AddUser(obj);
    }
}

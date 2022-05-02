using ApiBlogDDD.Application.DTO;
using ApiBlogDDD.Application.Interfaces;
using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Services;
using ApiBlogDDD.DTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiBlogDDD.Application.Services
{
    public class UserAppService : IUserAppService
    {
        private readonly IUserService _userService;
        //private readonly IAddressService _addressService;
        private readonly IMapper _mapper;

        public UserAppService(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        //public IEnumerable<User> GetAll() => _mapper.Map<List<User>>(_userService.GetAll().ToList());
        //public void AddAddress(User obj) => _addressService.AddAddress(_mapper.Map<Address>(obj.Address));

        public IEnumerable<User> GetAll() => _mapper.Map<List<User>>(_userService.GetAll().ToList());
        public void AddUser(User obj) => _userService.AddUser(_mapper.Map<User>(obj));


    }
}

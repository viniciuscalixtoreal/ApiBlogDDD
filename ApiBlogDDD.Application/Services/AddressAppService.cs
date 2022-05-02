using ApiBlogDDD.Application.DTO;
using ApiBlogDDD.Application.Interfaces;
using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiBlogDDD.Application.Services
{
    //public class AddressAppService : ApplicationBase<Address>, IAddressAppService
    //{
    //    //private readonly IAddressService _addressService;
    //    private readonly IMapper _mapper;

    //    //public AddressAppService(IAddressService addressService, IMapper mapper) : base(addressService)
    //    //{
    //    //    _addressService = addressService;
    //    //    _mapper = mapper;
    //    //}

    //    public IEnumerable<AddressViewModel> GetAll() => _mapper.Map<List<AddressViewModel>>(_addressService.GetAll().ToList());
    //    public void AddAddress(AddressViewModel obj) => _addressService.Add(_mapper.Map<Address>(obj));
    //}
}

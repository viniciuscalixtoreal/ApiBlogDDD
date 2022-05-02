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
    //public class GeoAppService : ApplicationBase<Geo>, IGeoAppService
    //{
    //    private readonly IGeoService _geoService;
    //    private readonly IMapper _mapper;

    //    public GeoAppService(IGeoService geoService, IMapper mapper) : base(geoService)
    //    {
    //        _geoService = geoService;
    //        _mapper = mapper;
    //    }

    //    public IEnumerable<GeoViewModel> GetAll() => _mapper.Map<List<GeoViewModel>>(_geoService.GetAll().ToList());
    //    public void AddGeo(GeoViewModel obj) => _geoService.Add(_mapper.Map<Geo>(obj));
    //}
}

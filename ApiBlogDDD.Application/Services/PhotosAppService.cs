using ApiBlogDDD.Application.Interfaces;
using ApiBlogDDD.Application.ViewModels;
using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Services;
using ApiBlogDDD.Domain.Services.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiBlogDDD.Application.Services
{
    public class PhotosAppService : IPhotosAppService
    {
        private readonly IPhotosService _photosService;
        private readonly IMapper _mapper;

        public PhotosAppService(IPhotosService photosService, IMapper mapper) 
        {
            _photosService = photosService;
            _mapper = mapper;
        }

        public IEnumerable<Photos> GetAll() => _mapper.Map<List<Photos>>(_photosService.GetAll().ToList());
        public void AddPhotos(Photos photos) => _photosService.AddPhotos(_mapper.Map<Photos>(photos));
    }
}

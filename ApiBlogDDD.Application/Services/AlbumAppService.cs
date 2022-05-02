using ApiBlogDDD.Application.Interfaces;
using ApiBlogDDD.Application.ViewModels;
using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiBlogDDD.Application.Services
{
    public class AlbumAppService : IAlbumAppService
    {
        private readonly IAlbumService _albumService;
        private readonly IMapper _mapper;

        public AlbumAppService(IAlbumService albumService, IMapper mapper) 
        {
            _albumService = albumService;
            _mapper = mapper;

        }

        public IEnumerable<Albums> GetAll() => _mapper.Map<List<Albums>>(_albumService.GetAll().ToList());

        public void AddAlbum(Albums obj) => _albumService.AddAlbum(_mapper.Map<Albums>(obj));

    }
}

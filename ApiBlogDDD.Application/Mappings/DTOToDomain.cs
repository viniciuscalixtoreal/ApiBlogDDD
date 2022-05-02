using ApiBlogDDD.Application.DTO;
using ApiBlogDDD.Application.Services;
using ApiBlogDDD.Application.ViewModels;
using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.DTO;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Application.Mappings
{
    public class DTOToDomain : Profile
    {
        public DTOToDomain()
        {
            CreateMap<AddressViewModel, Address>();
            CreateMap<AlbumsViewModel, Albums>();
            CreateMap<CommentsViewModel, Comments>();
            CreateMap<CompanyViewModel, Company>();
            CreateMap<GeoViewModel, Geo>();
            CreateMap<PhotosViewModel, Photos>();
            CreateMap<PostViewModel, Post>();
            CreateMap<UserViewModel, User>().ReverseMap();
            CreateMap<UserDTO, User>().ReverseMap();
        }
    }
}

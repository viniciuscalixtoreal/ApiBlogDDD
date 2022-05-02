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
    public class PostAppService : IPostAppService
    {
        private readonly IPostService _postService;
        private readonly IMapper _mapper;

        public PostAppService(IPostService postService, IMapper mapper)
        {
            _postService = postService;
            _mapper = mapper;
        }

        public IEnumerable<Post> GetAll() => _mapper.Map<List<Post>>(_postService.GetAll().ToList());
        public void AddPost(Post post) => _postService.AddPost(_mapper.Map<Post>(post));
    }
}

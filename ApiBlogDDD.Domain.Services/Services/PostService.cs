using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Repositories;
using ApiBlogDDD.Domain.Interfaces.Repositories.Dapper;
using ApiBlogDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Services.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepositoryDapper _postRepository;

        public PostService(IPostRepositoryDapper postRepository) 
        {
            _postRepository = postRepository;
        }

        public IEnumerable<Post> GetAll() => _postRepository.GetAll();

        public void AddPost(Post obj) => _postRepository.AddPost(obj);
    }
}

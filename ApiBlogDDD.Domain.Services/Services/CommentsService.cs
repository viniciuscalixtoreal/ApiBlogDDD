using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Repositories;
using ApiBlogDDD.Domain.Interfaces.Repositories.Dapper;
using ApiBlogDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Services.Services
{
    public class CommentsService : ICommentsService
    {
        private readonly ICommentsRepositoryDapper _commentsService;

        public CommentsService(ICommentsRepositoryDapper commentsService) 
        {
            _commentsService = commentsService;
        }

        public IEnumerable<Comments> GetAll() => _commentsService.GetAll();

        public void AddComments(Comments obj) => _commentsService.AddComments(obj);
    }
}

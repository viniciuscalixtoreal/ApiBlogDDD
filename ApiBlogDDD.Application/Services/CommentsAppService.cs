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
    public class CommentsAppService : ICommentsAppService
    {
        private readonly ICommentsService _commentsService;
        private readonly IMapper _mapper;

        public CommentsAppService(ICommentsService commentsService, IMapper mapper) 
        {
            _commentsService = commentsService;

        }

        public IEnumerable<Comments> GetAll() => _mapper.Map<List<Comments>>(_commentsService.GetAll().ToList());
        public void AddComments(Comments obj) => _commentsService.AddComments(_mapper.Map<Comments>(obj));
    }
}

using ApiBlogDDD.Application.ViewModels;
using ApiBlogDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Application.Interfaces
{
    public interface ICommentsAppService 
    {
        IEnumerable<Comments> GetAll();
        void AddComments(Comments obj);
    }
}

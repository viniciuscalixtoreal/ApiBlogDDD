using ApiBlogDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Interfaces.Services
{
    public interface ICommentsService 
    {
        IEnumerable<Comments> GetAll();
        void AddComments(Comments obj);
    }
}

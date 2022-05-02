using ApiBlogDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Interfaces.Services
{
    public interface IPostService 
    {
        IEnumerable<Post> GetAll();
        void AddPost(Post obj);
    }
}

using ApiBlogDDD.Application.ViewModels;
using ApiBlogDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Application.Interfaces
{
    public interface IPostAppService //: IApplicationBase<Post>
    {
        IEnumerable<Post> GetAll();
        void AddPost(Post obj);
    }
}

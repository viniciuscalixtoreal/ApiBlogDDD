using ApiBlogDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Interfaces.Repositories.Dapper
{
    public interface IPostRepositoryDapper //: IRepositoryBase<Post>
    {
        IEnumerable<Post> GetAll();
        void AddPost(Post obj);
    }
}

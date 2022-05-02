using ApiBlogDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Interfaces.Repositories.Dapper
{
    public interface ICommentsRepositoryDapper //: IRepositoryBase<Comments>
    {
        IEnumerable<Comments> GetAll();
        void AddComments(Comments obj);
    }
}

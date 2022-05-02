using ApiBlogDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Interfaces.Repositories.Dapper
{
    public interface IAddressRepositoryDapper //: IRepositoryBase<Address>
    {
        IEnumerable<Address> GetAll();
        int AddAddress(Address address);
    }
}

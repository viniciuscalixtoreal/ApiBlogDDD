using ApiBlogDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Interfaces.Repositories.Dapper
{
    public interface ICompanyRepositoryDapper //: IRepositoryBase<Company>
    {
        IEnumerable<Company> GetAll();
        int AddCompany(Company company);
    }
}

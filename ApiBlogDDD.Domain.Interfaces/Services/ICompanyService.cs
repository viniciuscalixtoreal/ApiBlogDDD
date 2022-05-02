using ApiBlogDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Domain.Interfaces.Services
{
    public interface ICompanyService : IServiceBase<Company>
    {
        IEnumerable<Company> GetAll();
        void AddCompany(Company company);
    }
}

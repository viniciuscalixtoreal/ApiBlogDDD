using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Repositories.Dapper;
using ApiBlogDDD.Domain.Interfaces.Services;
using ApiBlogDDD.DTO;
using AutoMapper;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;

namespace ApiBlogDDD.Infra.Data.Repository.Dapper
{
    public class UserRepositoryDapper : DapperRepository, IUserRepositoryDapper
    {
        private readonly IConfiguration _config;
        private readonly IAddressRepositoryDapper _addressRepository;
        private readonly ICompanyRepositoryDapper _companyRepositoryDapper;
        //private readonly IAddressService _addressService;
        //private readonly IMapper _mapper;


        public UserRepositoryDapper(IConfiguration config,
            IAddressRepositoryDapper addressRepositoryDapper,
            ICompanyRepositoryDapper companyRepositoryDapper)
            : base(config.GetConnectionString("DefaultConnection"))
        {
            _config = config;
            _addressRepository = addressRepositoryDapper;
            _companyRepositoryDapper = companyRepositoryDapper;
        }

        public IEnumerable<User> GetAll()
        {
            using var dbConnection = Connection;
            dbConnection.Open();

            return dbConnection.Query<User>("SELECT * FROM Users WITH(NOLOCK)");
        }

        public void AddUser(User obj)
        {

            using IDbConnection dbConnection = Connection;


            var address = new Address
            {
                Street = obj.Address.Street,
                Suite = obj.Address.Suite,
                City = obj.Address.City,
                Zipcode = obj.Address.Zipcode,
                Geo = obj.Address.Geo
            };

            var company = new Company
            {
                Name = obj.Company.Name,
                CatchPhrase = obj.Company.CatchPhrase,
                BS = obj.Company.BS
            };

            
            int addressId = _addressRepository.AddAddress(address);
            int CompanyId = _companyRepositoryDapper.AddCompany(company);

            var geo = new Geo
            {
                Lat = obj.Address.Geo.Lat,
                Lng = obj.Address.Geo.Lng
            };



            //};

            //var AddressId = obj.Address.Id;
            //var CompanyId = obj.Company.Id;

            var sQuery = @$"INSERT INTO [Users] (AddressId, CompanyId, Name, Username, Email, Phone, WebSite)
                                        VALUES({addressId}, {CompanyId}, @Name, @UserName, @Email, @Phone, @WebSite)";

            dbConnection.Open();
            dbConnection.Execute(sQuery, obj);
        }
    }
}

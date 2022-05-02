using ApiBlogDDD.Application.DTO;
using ApiBlogDDD.Application.Interfaces;
using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiBlogDDD.Application.Services
{
    //public class CompanyAppService : ApplicationBase<Company>, ICompanyAppService
    //{
    //    private readonly ICompanyService _companyService;
    //    private readonly IMapper _mapper;

    //    public CompanyAppService(ICompanyService companyService, IMapper mapper) : base(companyService)
    //    {
    //        _companyService = companyService;
    //        _mapper = mapper;
    //    }

    //    public IEnumerable<CompanyViewModel> GetAll() => _mapper.Map<List<CompanyViewModel>>(_companyService.GetAll().ToList());

    //    public void AddCompany(CompanyViewModel obj) => _companyService.Add(_mapper.Map<Company>(obj));
    //}
}

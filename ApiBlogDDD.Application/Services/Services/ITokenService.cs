using ApiBlogDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBlogDDD.Application.Services.Services
{
    public interface ITokenService
    {
        string GenerateToken(Authenticate user);
    }
}

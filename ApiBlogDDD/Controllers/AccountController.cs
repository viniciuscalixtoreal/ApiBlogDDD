using ApiBlogDDD.Application.Services.Services;
using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Repositories.Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiBlogDDD.Controllers
{
    [ApiController]
    [Route("v1")]
    public class AccountController : ApiController
    {
        private readonly IAuthenticateRepositoryDapper _authenticateRepository;
        private readonly IUserRepositoryDapper _userRepository;
        private readonly ITokenService _tokenService;

        public AccountController(IAuthenticateRepositoryDapper authenticateRepository, IUserRepositoryDapper userRepository, ITokenService tokenService)
        {
            _authenticateRepository = authenticateRepository;
            _userRepository = userRepository;
            _tokenService = tokenService;
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public IActionResult Authenticate([FromBody] Authenticate model)
        {
            var user = _authenticateRepository.GetUser(model);

            if (user == null)
                return BadRequest(new { message = "Usuário ou senha inválidos" });

            var token = _tokenService.GenerateToken(user);

            return Ok( new Authenticate
            {
                Success = true,
                Token = token,
                Id = user.Id,
                Username = user.Username
            });
        }
    }
}

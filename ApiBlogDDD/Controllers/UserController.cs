using ApiBlogDDD.Application.DTO;
using ApiBlogDDD.Application.Interfaces;
using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Repositories.Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiBlogDDD.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserAppService _userAppService;

        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [HttpGet]
        [Route("users")]
        [AllowAnonymous]
        public IActionResult Get()
        {
            var post = _userAppService.GetAll();

            return Ok(post);
        }

        [HttpPost]
        [Route("usersAdd")]
        //[Authorize]
        public IActionResult Post([FromBody] User model)
        {
            if(ModelState.IsValid)
            {
                _userAppService.AddUser(model);
                return Ok("Usuário cadastrado com sucesso.");
            }

            return BadRequest("Erro: Não foi possível gravar o registro.");
        }
    }
}

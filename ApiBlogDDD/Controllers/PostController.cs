using ApiBlogDDD.Application.Interfaces;
using ApiBlogDDD.Application.ViewModels;
using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Repositories.Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiBlogDDD.Controllers
{
    public class PostController : ApiController
    {
        private readonly IPostAppService _postAppService;

        public PostController(IPostAppService postAppService)
        {
            _postAppService = postAppService;
        }

        [HttpGet]
        [Route("posts")]
        [AllowAnonymous]
        public IActionResult Get()
        {
            var post = _postAppService.GetAll();

            return Ok(post);
        }

        [HttpPost]
        [Route("postAdd")]
        //[Authorize]
        public IActionResult Post([FromBody] Post model)
        {
            if (ModelState.IsValid)
            {
                _postAppService.AddPost(model);
                return Ok("Post cadastrado com sucesso.");
            }

            return BadRequest("Erro: Não foi possível gravar o registro.");
        }
    }
}

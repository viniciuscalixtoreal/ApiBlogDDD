using ApiBlogDDD.Application.Interfaces;
using ApiBlogDDD.Application.ViewModels;
using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Repositories.Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiBlogDDD.Controllers
{
    public class CommentsController : ApiController
    {
        private readonly ICommentsAppService _commentsAppService;

        public CommentsController(ICommentsAppService commentsAppService)
        {
            _commentsAppService = commentsAppService;
        }

        [HttpGet]
        [Route("comments")]
        [AllowAnonymous]
        public IActionResult Get()
        {
            var post = _commentsAppService.GetAll();

            return Ok(post);
        }

        [HttpPost]
        [Route("commentsAdd")]
        //[Authorize]
        public IActionResult Post([FromBody] Comments model)
        {
            if (ModelState.IsValid)
            {
                _commentsAppService.AddComments(model);

                return Ok("Comentário cadastrado com sucesso.");
            }

            return BadRequest("Erro: Não foi possível gravar o registro.");
        }
    }
}

using ApiBlogDDD.Application.Interfaces;
using ApiBlogDDD.Application.ViewModels;
using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Repositories.Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiBlogDDD.Controllers
{
    public class AlbumsController : ApiController
    {
        private readonly IAlbumAppService _albumAppService;

        public AlbumsController(IAlbumAppService albumAppService)
        {
            _albumAppService = albumAppService;
        }

        [HttpGet]
        [Route("albums")]
        [AllowAnonymous]
        public IActionResult Get()
        {
            var post = _albumAppService.GetAll();

            return Ok(post);
        }

        [HttpPost]
        [Route("albumsAdd")]
        //[Authorize]
        public IActionResult Post([FromBody] Albums model)
        {
            if (ModelState.IsValid)
            {
                _albumAppService.AddAlbum(model);

                return Ok("Album cadastrado com sucesso.");
            }
            return BadRequest("Erro: Não foi possível gravar o registro.");
        }
    }
}

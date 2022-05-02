using ApiBlogDDD.Application.Interfaces;
using ApiBlogDDD.Application.ViewModels;
using ApiBlogDDD.Domain.Entities;
using ApiBlogDDD.Domain.Interfaces.Repositories.Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiBlogDDD.Controllers
{
    public class PhotosController : ApiController
    {
        private readonly IPhotosAppService _photosAppService;

        public PhotosController(IPhotosAppService photosAppService)
        {
            _photosAppService = photosAppService;
        }

        [HttpGet]
        [Route("photos")]
        [AllowAnonymous]
        public IActionResult Get()
        {
            var post = _photosAppService.GetAll();

            return Ok(post);
        }

        [HttpPost]
        [Route("photosAdd")]
        //[Authorize]
        public IActionResult Post(Photos model)
        {
            if (ModelState.IsValid)
            {
                _photosAppService.AddPhotos(model);
                return Ok("Photos cadastrado com sucesso.");
            }

            return BadRequest("Erro: Não foi possível gravar o registro.");
        }

    }
}

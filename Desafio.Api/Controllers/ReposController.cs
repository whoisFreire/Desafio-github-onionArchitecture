using Desafio.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Desafio.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ReposController : ControllerBase
    {
        private readonly IGithubService _githubService;

        public ReposController(IGithubService githubService)
        {
            _githubService = githubService;
        }

        [HttpGet("{orgname}")]
        public async Task<IActionResult> GetAllRepos([FromRoute] string orgname)
        {
            var repos = await _githubService.GetAllRepos(orgname);
            return Ok(repos);
        }

        [HttpGet("{orgname}/{language}")]
        public async Task<IActionResult> GetByLanguage([FromRoute] string orgname, [FromRoute] string language)
        {
            var repos = await _githubService.GetByLanguage(orgname, language);
            return Ok(repos);
        }

    }
}

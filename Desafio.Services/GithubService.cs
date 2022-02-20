using Desafio.Domain.Models;
using Desafio.Services.Interfaces;
using RestEase;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Services
{
    public class GithubService : IGithubService
    {
        private readonly IGithubService _githubClient;

        public GithubService(IGithubService githubClient)
        {
            _githubClient = githubClient;
        }

        public Task<List<GithubResponse>> GetAllRepos([Path("orgname")] string orgname)
        {
            return _githubClient.GetAllRepos(orgname);
        }

        public async Task<List<GithubResponse>> GetByLanguage(string orgname, string language)
        {
            var allrepos = await GetAllRepos(orgname);
            var reposByLanguage = from repo in allrepos where repo.Language == language select repo;

            return reposByLanguage.ToList();

        }
    }
}

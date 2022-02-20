using Desafio.Domain.Models;
using RestEase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.Services.Interfaces
{
    [Header("User-Agent", "Restease")]
    public interface IGithubService
    {
        [Get("orgs/{orgname}/repos")]
        Task<List<GithubResponse>> GetAllRepos([Path("orgname")] string orgname);

        [Get("orgs/{orgname}/repos")]
        Task<List<GithubResponse>> GetByLanguage([Path("orgname")] string orgname, string language);
    }
}

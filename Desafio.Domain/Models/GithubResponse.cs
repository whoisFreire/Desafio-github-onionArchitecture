using Newtonsoft.Json;
using System;


namespace Desafio.Domain.Models
{
    public class GithubResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [JsonProperty("html_url")]
        public string UrlRepo { get; set; }
        [JsonProperty("language")]
        public string Language { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

    }
}

using MIO.Football.Domain.Entities.Campeonato;
using MIO.Football.Domain.Entities.Matches;
using MIO.Football.Domain.Entities.Standings;
using MIO.Football.Domain.Entities.Team;
using MIO.Football.Domain.Interfaces.IServices;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MIO.Football.Services.Services
{
    public class CampeonatoService : BaseService, ICampeonatoService
    {
        public async Task<Campeonato> SearchCompetitions(string Code)
        {
            string url =string.Format("{0}competitions/{1}", UrlBase, Code);
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Auth-Token", Token);
                var resposta = await client.GetStringAsync(url);

                Campeonato retorno = JsonConvert.DeserializeObject<Campeonato>(resposta);
                return retorno;
            }
        }

        public async Task<StandingsEntity> SearchStandings(string Code)
        {
            string url = string.Format("{0}competitions/{1}/standings", UrlBase, Code);
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Auth-Token", Token);
                var resposta = await client.GetStringAsync(url);

                StandingsEntity retorno = JsonConvert.DeserializeObject<StandingsEntity>(resposta);
                return retorno;
            }
        }

        public async Task<TeamComplete> ListTeams(string Code)
        {
            string url = string.Format("{0}competitions/{1}/teams", UrlBase, Code);
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Auth-Token", Token);
                var resposta = await client.GetStringAsync(url);

                TeamComplete retorno = JsonConvert.DeserializeObject<TeamComplete>(resposta);
                return retorno;
            }
        }

        public async Task<MatchesComplete> ListMatches(string Code)
        {
            string url = string.Format("{0}competitions/{1}/matches", UrlBase, Code);
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Auth-Token", Token);
                var resposta = await client.GetStringAsync(url);

                MatchesComplete retorno = JsonConvert.DeserializeObject<MatchesComplete>(resposta);
                return retorno;
            }
        }
    }
}
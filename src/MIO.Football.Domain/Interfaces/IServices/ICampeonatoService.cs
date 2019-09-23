using MIO.Football.Domain.Entities.Campeonato;
using MIO.Football.Domain.Entities.Matches;
using MIO.Football.Domain.Entities.Standings;
using MIO.Football.Domain.Entities.Team;
using System.Threading.Tasks;

namespace MIO.Football.Domain.Interfaces.IServices
{
    public interface ICampeonatoService
    {
        Task<Campeonato> SearchCompetitions(string Code);
        Task<StandingsEntity> SearchStandings(string Code);
        Task<TeamComplete> ListTeams(string Code);
        Task<MatchesComplete> ListMatches(string Code);
    }
}
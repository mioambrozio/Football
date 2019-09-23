using MIO.Football.Application.ViewModel.Campeonato;
using MIO.Football.Application.ViewModel.Matches;
using MIO.Football.Application.ViewModel.Standings;
using MIO.Football.Application.ViewModel.Team;

namespace MIO.Football.Application.Interfaces
{
    public interface ICampeonatoApplicationService
    {
        CampeonatoViewModel SearchCompetitions(string Code);
        StandingsEntityViewModel SearchStandings(string Code);
        TeamCompleteViewModel ListTeams(string Code);
        MatchesCompleteViewModel ListMatches(string Code);
    }
}
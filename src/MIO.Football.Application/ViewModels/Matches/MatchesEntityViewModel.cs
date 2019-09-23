using MIO.Football.Application.ViewModel.Campeonato;
using System.Collections.Generic;

namespace MIO.Football.Application.ViewModel.Matches
{
    public class MatchesEntityViewModel
    {
        public int id { get; set; }
        public SeasonBaseViewModel season { get; set; }
        public string utcDate { get; set; }
        public string status { get; set; }
        public int matchday { get; set; }
        public string stage { get; set; }
        public string group { get; set; }
        public string lastUpdated { get; set; }
        public ScoreViewModel score { get; set; }
        /// <summary>
        /// Time da casa
        /// </summary>
        public DetailTeamViewModel homeTeam { get; set; }
        /// <summary>
        /// Time Convidado
        /// </summary>
        public DetailTeamViewModel awayTeam { get; set; }
        public List<PlayerViewModel> referees { get; set; }
    }
}
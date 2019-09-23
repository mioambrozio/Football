using MIO.Football.Domain.Entities.Campeonato;
using System.Collections.Generic;

namespace MIO.Football.Domain.Entities.Matches
{
    public class MatchesEntity
    {
        public int id { get; set; }
        public SeasonBase season { get; set; }
        public string utcDate { get; set; }
        public string status { get; set; }
        public int matchday { get; set; }
        public string stage { get; set; }
        public string group { get; set; }
        public string lastUpdated { get; set; }
        public Score score { get; set; }
        /// <summary>
        /// Time da casa
        /// </summary>
        public DetailTeam homeTeam { get; set; }
        /// <summary>
        /// Time Convidado
        /// </summary>
        public DetailTeam awayTeam { get; set; }
        public List<Player> referees { get; set; }
    }
}
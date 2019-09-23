using MIO.Football.Domain.Entities.Campeonato;
using System.Collections.Generic;

namespace MIO.Football.Domain.Entities.Standings
{
    public class StandingsEntity
    {
        public CampeonatoBase competition { get; set; }
        public Season season { get; set; }
        public List<StandingsBase> standings { get; set; }
    }
}
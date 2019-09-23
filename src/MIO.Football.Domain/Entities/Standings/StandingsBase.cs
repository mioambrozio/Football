using System.Collections.Generic;

namespace MIO.Football.Domain.Entities.Standings
{
    public class StandingsBase
    {
        public string stage { get; set; }
        public string type { get; set; }
        public List<TableTeam> table { get; set; }
    }
}
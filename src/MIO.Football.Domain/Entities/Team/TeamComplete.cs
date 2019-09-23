using System.Collections.Generic;

namespace MIO.Football.Domain.Entities.Team
{
    public class TeamComplete
    {
        public int count { get; set; }
        public List<TeamEntity> teams { get; set; }
    }
}
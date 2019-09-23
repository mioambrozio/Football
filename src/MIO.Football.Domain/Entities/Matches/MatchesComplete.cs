using System.Collections.Generic;

namespace MIO.Football.Domain.Entities.Matches
{
    public class MatchesComplete
    {
        public int count { get; set; }
        public List<MatchesEntity> matches { get; set; }
    }
}
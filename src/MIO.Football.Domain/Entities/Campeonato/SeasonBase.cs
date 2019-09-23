using System;

namespace MIO.Football.Domain.Entities.Campeonato
{
    public class SeasonBase
    {
        public int? id { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public int? currentMatchday { get; set; }
    }
}
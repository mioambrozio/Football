using System;

namespace MIO.Football.Domain.Entities.Campeonato
{
    public class CampeonatoBase
    {
        public int? id { get; set; }
        public Area area { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string plan { get; set; }
        public DateTime lastUpdated { get; set; }
    }
}
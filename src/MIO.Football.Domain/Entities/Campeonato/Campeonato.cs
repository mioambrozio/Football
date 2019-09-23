namespace MIO.Football.Domain.Entities.Campeonato
{
    public class Campeonato : CampeonatoBase
    {
        public string emblemUrl { get; set; }
        public Season currentSeason { get; set; }
    }
}
using System.Collections.Generic;

namespace MIO.Football.Domain.Entities.Campeonato
{
    public class CampeonatoEntity : Campeonato
    {
        public List<Season> seasons { get; set; }
    }
}
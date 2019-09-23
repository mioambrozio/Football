using MIO.Football.Application.ViewModel.Campeonato;
using System.Collections.Generic;

namespace MIO.Football.Application.ViewModel.Standings
{
    public class StandingsEntityViewModel
    {
        public CampeonatoBaseViewModel competition { get; set; }
        public SeasonViewModel season { get; set; }
        public List<StandingsBaseViewModel> standings { get; set; }

        public StandingsEntityViewModel()
        {
            standings = new List<StandingsBaseViewModel>();
            season = new SeasonViewModel();
            competition = new CampeonatoBaseViewModel();
        }
    }
}
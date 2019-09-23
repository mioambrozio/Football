using MIO.Football.Application.ViewModel.Campeonato;

namespace MIO.Football.Application.ViewModel.Team
{
    public class TeamEntityViewModel : Standings.TeamViewModel
    {
        public AreaViewModel area { get; set; }
        public string shortName { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public string email { get; set; }
        public string founded { get; set; }
        public string clubColors { get; set; }
        public string venue { get; set; }
    }
}
using System.Collections.Generic;

namespace MIO.Football.Application.ViewModel.Team
{
    public class TeamCompleteViewModel
    {
        public int count { get; set; }
        public List<TeamEntityViewModel> teams { get; set; }
    }
}
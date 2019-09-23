using System.Collections.Generic;

namespace MIO.Football.Application.ViewModel.Matches
{
    public class MatchesCompleteViewModel
    {
        public int count { get; set; }
        public List<MatchesEntityViewModel> matches { get; set; }
    }
}
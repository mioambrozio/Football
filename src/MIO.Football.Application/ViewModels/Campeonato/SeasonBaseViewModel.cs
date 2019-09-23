using System;

namespace MIO.Football.Application.ViewModel.Campeonato
{
    public class SeasonBaseViewModel
    {
        public int? id { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
        public int? currentMatchday { get; set; }
    }
}
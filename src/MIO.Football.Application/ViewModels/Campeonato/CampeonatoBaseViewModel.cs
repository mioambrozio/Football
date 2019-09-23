using System;

namespace MIO.Football.Application.ViewModel.Campeonato
{
    public class CampeonatoBaseViewModel
    {
        public int? id { get; set; }
        public AreaViewModel area { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string plan { get; set; }
        public DateTime lastUpdated { get; set; }
    }
}
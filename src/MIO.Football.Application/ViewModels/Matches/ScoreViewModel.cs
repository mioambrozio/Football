namespace MIO.Football.Application.ViewModel.Matches
{
    public class ScoreViewModel
    {
        public string winner { get; set; }
        public string duration { get; set; }
        /// <summary>
        /// tempo total do jogo
        /// </summary>
        public FootbalTimeViewModel fullTime { get; set; }
        /// <summary>
        /// primeiro tempo
        /// </summary>
        public FootbalTimeViewModel halfTime { get; set; }
        /// <summary>
        /// Prorrogação
        /// </summary>
        public FootbalTimeViewModel extraTime { get; set; }
        public FootbalTimeViewModel penaltes { get; set; }
    }
}
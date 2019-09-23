namespace MIO.Football.Domain.Entities.Matches
{
    public class Score
    {
        public string winner { get; set; }
        public string duration { get; set; }
        /// <summary>
        /// tempo total do jogo
        /// </summary>
        public FootbalTime fullTime { get; set; }
        /// <summary>
        /// primeiro tempo
        /// </summary>
        public FootbalTime halfTime { get; set; }
        /// <summary>
        /// Prorrogação
        /// </summary>
        public FootbalTime extraTime { get; set; }
        public FootbalTime penaltes { get; set; }
    }
}
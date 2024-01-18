namespace GameAssessment.Models
{
    public class GameAssessmentOb
    {
        public string user { get; set; } //userId
        public string game { get; set; } //gameId
        public string gameReview { get; set; }
        public int gameAssessment { get; set; }
        public double hoursPlayed { get; set; }
    }
}
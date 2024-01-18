namespace GameAssessment.Models
{
    public class Game
    {
        public string gameId { get; set; }
        public string gameName { get; set; }
        public DateTime releaseDate { get; set; }
        public string producer { get; set; }
        public ICollection <GameAssessmentOb> gameAssessments{ get; set; }
        public ICollection <GameCategory> gameCategories {get; set; }
    }
}
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

        public Game(string gameName, DateTime releaseDate, string producer, ICollection<GameAssessmentOb> gameAssessments, ICollection<GameCategory> gameCategories)
        {
            this.gameId = Guid.NewGuid().ToString();
            this.gameName = gameName;
            this.releaseDate = releaseDate;
            this.producer = producer;
            this.gameAssessments = gameAssessments;
            this.gameCategories = gameCategories;
        }
    }
}
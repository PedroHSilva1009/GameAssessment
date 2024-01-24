using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameAssessment.Models
{
    [Table("game")]
    public class Game
    {

        public string? gameId { get; set; }
        public string gameName { get; set; }
        public DateTime releaseDate { get; set; }
        public string producer { get; set; }

        public Game(string gameId, string gameName, DateTime releaseDate, string producer)
        {
            this.gameId = gameId;
            this.gameName = gameName;
            this.releaseDate = releaseDate;
            this.producer = producer;
        }
        
    }
}
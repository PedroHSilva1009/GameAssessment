using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameAssessment.Models
{
    [Table("game")]
    public class Game
    {
        [Key]
        public string gameId { get; set; }
        public string gameName { get; set; }
        public DateTime releaseDate { get; set; }
        public string producer { get; set; }

        public Game(string gameName, DateTime releaseDate, string producer)
        {
            this.gameId = Guid.NewGuid().ToString();
            this.gameName = gameName;
            this.releaseDate = releaseDate;
            this.producer = producer;
        }
    }
}
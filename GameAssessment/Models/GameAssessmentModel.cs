using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameAssessment.Models
{

    [Table("gameassessment")]
    public class GameAssessmentOb
    {
        public string user { get; set; } //userId
        public string game { get; set; } //gameId
        public string gameReview { get; set; }
        public int gameAssessment { get; set; }
        public double hoursPlayed { get; set; }

        public GameAssessmentOb(string userId, string gameId, string gameReview, int gameAssessment, double hoursPlayed)
        {
            this.user = userId;
            this.game = gameId;
            this.gameReview = gameReview;
            this.gameAssessment = gameAssessment;
            this.hoursPlayed = hoursPlayed;
        }

        public GameAssessmentOb(){

        }

    }
}

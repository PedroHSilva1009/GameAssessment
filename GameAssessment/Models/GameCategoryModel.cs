using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameAssessment.Models
{
    public class GameCategory
    {
        public string game { get; set; } //gameId
        public string category { get; set; }//categoryId   
    }
}
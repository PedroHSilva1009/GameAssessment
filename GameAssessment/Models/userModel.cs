using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameAssessment.Models
{
    [Table("User")]
    public class User{
        [Key]
        public string userId {get; set;}
        public string nickName {get; set;}
        public string userName {get; set;}
        public string email { get; set; }
        public string password { get; set; }
        public int acessLevel { get; set; }
        public ICollection<GameAssessmentOb> GameAssessments { get; set; }

        public User(string nickName, string userName, string email, string password, int acessLevel, ICollection<GameAssessmentOb> GameAssessments)
        {
            this.userId = Guid.NewGuid().ToString();
            this.nickName = nickName;
            this.userName = userName;
            this.email = email;
            this.password = password;
            this.acessLevel = acessLevel;
            this.GameAssessments = GameAssessments;
        }

        public User(){

        }
    }   
}
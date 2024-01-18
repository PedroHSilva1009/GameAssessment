namespace GameAssessment.Models
{
    public class User{
        public string userId {get; set;}
        public string nickName {get; set;}
        public string userName {get; set;}
        public string email { get; set; }
        public string password { get; set; }
        public int acessLevel { get; set; }
        public ICollection<GameAssessmentOb> GameAssessments { get; set; }
    }   
}
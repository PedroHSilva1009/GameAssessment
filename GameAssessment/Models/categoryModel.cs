namespace GameAssessment.Models
{
    public class categoryModel{
        private string categoryId {get; set;}
        private string categoryName {get; set;}
        private ICollection<Game> games {get; set;}
        
    }
}
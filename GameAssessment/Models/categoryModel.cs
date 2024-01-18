namespace GameAssessment.Models
{
    public class Category
    {
        public string categoryId { get; set; }
        public string categoryName { get; set; }
        public ICollection<GameCategory> gameCategories{ get; set; }
    }
}


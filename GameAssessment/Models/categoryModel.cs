using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameAssessment.Models
{
    [Table("category")]
    public class Category
    {
        [Key]
        public string? categoryId { get; set; }
        public string categoryName { get; set; }
        public ICollection<GameCategory>? gameCategories{ get; set; }

        public Category(string categoryId, string categoryName)
        {
            this.categoryId = categoryId;
            this.categoryName = categoryName;
        }

        public Category(){

        }
    }
}


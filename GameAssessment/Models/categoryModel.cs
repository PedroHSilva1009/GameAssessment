using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameAssessment.Models
{
    [Table("category")]
    public class Category
    {
        [Key]
        public string categoryId { get; set; }
        public string categoryName { get; set; }
        public ICollection<GameCategory> gameCategories{ get; set; }

        public Category(string categoryName, ICollection<GameCategory> gameCategories)
        {
            this.categoryId = Guid.NewGuid().ToString();
            this.categoryName = categoryName;
            this.gameCategories = gameCategories;
        }

        public Category(){

        }
    }
}


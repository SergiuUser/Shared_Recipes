using System.ComponentModel.DataAnnotations;

namespace Shared_Recipes.Models
{
    public class Recipes
    {
        [Key]
        private int id { get; set;}
        public string Title { get; set; }
    }
}

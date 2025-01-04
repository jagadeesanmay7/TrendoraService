using System.ComponentModel.DataAnnotations;

namespace Trendora.Domain.Models
{
    public class Category : BaseModel
    {
        [Required]
        public string Name { get; set; }
    }
}

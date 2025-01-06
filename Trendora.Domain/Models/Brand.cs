using System.ComponentModel.DataAnnotations;

namespace Trendora.Domain.Models
{
    public class Brand : BaseModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int EstablishedYear { get; set; }
    }
}

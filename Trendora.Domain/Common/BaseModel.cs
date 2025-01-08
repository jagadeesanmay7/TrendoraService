using System.ComponentModel.DataAnnotations;

namespace Trendora.Domain.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;
    }
}

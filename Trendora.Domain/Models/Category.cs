using System.ComponentModel.DataAnnotations;

namespace Trendora.Domain.Models
{
    public class Catagory : BaseModel
    {
        [Required]
        public string Name { get; set; }
    }
}

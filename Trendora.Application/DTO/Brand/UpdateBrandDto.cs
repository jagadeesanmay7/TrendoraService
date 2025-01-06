using System.ComponentModel.DataAnnotations;

namespace Trendora.Application.DTO.Brand
{
    public class UpdateBrandDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int EstablishedYear { get; set; }
    }
}

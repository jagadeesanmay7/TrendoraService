using System.ComponentModel.DataAnnotations;

namespace Trendora.Application.DTO.Brand
{
    public class CreateBrandDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int EstablishedYear { get; set; }
    }
}

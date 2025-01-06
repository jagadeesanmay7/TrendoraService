using System.ComponentModel.DataAnnotations;

namespace Trendora.Application.DTO.Brand
{
    public class BrandDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EstablishedYear { get; set; }
    }
}

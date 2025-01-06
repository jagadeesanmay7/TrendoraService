using Trendora.Application.DTO.Brand;

namespace Trendora.Application.Services.Interface
{
    public interface IBrandService
    {
        Task<BrandDto> GetByIdAsync(int id);
        Task<IEnumerable<BrandDto>> GetAllAsync();
        Task<BrandDto> CreateAsync(CreateBrandDto createBrandDto);
        Task UpdateAsync(UpdateBrandDto updateBrandDto);
        Task DeleteAsync(int id);
    }
}

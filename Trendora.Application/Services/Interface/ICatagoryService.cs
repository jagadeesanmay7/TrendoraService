using Trendora.Application.DTO.Catagory;

namespace Trendora.Application.Services.Interface
{
    public interface ICatagoryService
    {
        Task<CatagoryDto> GetByIdAsync(int id);
        Task<IEnumerable<CatagoryDto>> GetAllAsync();
        Task<CatagoryDto> CreateAsync(CreateCatagoryDto createCatagoryDto);
        Task UpdateAsync(UpdateCatagoryDto updateCatagoryDto);
        Task DeleteAsync(int id);
    }
}

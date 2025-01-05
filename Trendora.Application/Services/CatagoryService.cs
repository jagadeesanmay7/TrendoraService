using AutoMapper;
using Trendora.Application.DTO.Catagory;
using Trendora.Application.Services.Interface;
using Trendora.Domain.Interface;
using Trendora.Domain.Models;

namespace Trendora.Application.Services
{
    public class CatagoryService : ICatagoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CatagoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<CatagoryDto> CreateAsync(CreateCatagoryDto createCatagoryDto)
        {
            var catagory = _mapper.Map<Catagory>(createCatagoryDto);
            var createdEntity = await _categoryRepository.CreateAsync(catagory);
            var entity = _mapper.Map<CatagoryDto>(createdEntity);
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var catagory = await _categoryRepository.GetByIdAsync(x => x.Id == id);
            await _categoryRepository.DeleteAsync(catagory);
        }

        public async Task<IEnumerable<CatagoryDto>> GetAllAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();
            return _mapper.Map<List<CatagoryDto>>(categories);
        }

        public async Task<CatagoryDto> GetByIdAsync(int id)
        {
            var catagory = await _categoryRepository.GetByIdAsync(x => x.Id == id);
            return _mapper.Map<CatagoryDto>(catagory);
        }

        public async Task UpdateAsync(UpdateCatagoryDto updateCatagoryDto)
        {
            var catagory = _mapper.Map<Catagory>(updateCatagoryDto);
            await _categoryRepository.UpdateAsync(catagory);
        }
    }
}

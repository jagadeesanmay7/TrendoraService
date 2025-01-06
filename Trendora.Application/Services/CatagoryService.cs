using AutoMapper;
using Trendora.Application.DTO.Catagory;
using Trendora.Application.Services.Interface;
using Trendora.Domain.Interface;
using Trendora.Domain.Models;

namespace Trendora.Application.Services
{
    public class CatagoryService : ICatagoryService
    {
        private readonly ICatagoryRepository _catagoryRepository;
        private readonly IMapper _mapper;

        public CatagoryService(ICatagoryRepository catagoryRepository, IMapper mapper)
        {
            _catagoryRepository = catagoryRepository;
            _mapper = mapper;
        }
        public async Task<CatagoryDto> CreateAsync(CreateCatagoryDto createCatagoryDto)
        {
            var catagory = _mapper.Map<Catagory>(createCatagoryDto);
            var createdEntity = await _catagoryRepository.CreateAsync(catagory);
            var entity = _mapper.Map<CatagoryDto>(createdEntity);
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var catagory = await _catagoryRepository.GetByIdAsync(x => x.Id == id);
            await _catagoryRepository.DeleteAsync(catagory);
        }

        public async Task<IEnumerable<CatagoryDto>> GetAllAsync()
        {
            var catagories = await _catagoryRepository.GetAllAsync();
            return _mapper.Map<List<CatagoryDto>>(catagories);
        }

        public async Task<CatagoryDto> GetByIdAsync(int id)
        {
            var catagory = await _catagoryRepository.GetByIdAsync(x => x.Id == id);
            return _mapper.Map<CatagoryDto>(catagory);
        }

        public async Task UpdateAsync(UpdateCatagoryDto updateCatagoryDto)
        {
            var catagory = _mapper.Map<Catagory>(updateCatagoryDto);
            await _catagoryRepository.UpdateAsync(catagory);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Trendora.Domain.Interface;
using Trendora.Domain.Models;

namespace Trendora.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public async Task<ActionResult> CreateCategory([FromBody] Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity = await _categoryRepository.CreateAsync(category);
            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var category = await _categoryRepository.GetAllAsync();
            return Ok(category);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Route("Details")]
        public async Task<ActionResult> GetCategoryById(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(x => x.Id == id);
            if (category == null)
            {
                return NotFound($"Category not found for Id - {id}");
            }
            return Ok(category);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut]
        public async Task<ActionResult> UpdateCategory(Category category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _categoryRepository.UpdateAsync(category);
            return NoContent();
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete]
        public async Task<ActionResult> DeleteCategory(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var category = await _categoryRepository.GetByIdAsync(x => x.Id == id);

            if (category == null)
            {
                return NotFound();
            }
            await _categoryRepository.DeleteAsync(category);
            return NoContent();
        }
    }
}

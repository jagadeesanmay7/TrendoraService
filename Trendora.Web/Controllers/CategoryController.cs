using Microsoft.AspNetCore.Mvc;
using Trendora.Application.DTO.Catagory;
using Trendora.Application.Services.Interface;
using Trendora.Domain.Interface;
using Trendora.Domain.Models;

namespace Trendora.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICatagoryService _categoryService;

        public CategoryController(ICatagoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public async Task<ActionResult> CreateCategory([FromBody] CreateCatagoryDto catagory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity = await _categoryService.CreateAsync(catagory);
            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var catagory = await _categoryService.GetAllAsync();
            return Ok(catagory);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Route("Details")]
        public async Task<ActionResult> GetCategoryById(int id)
        {
            var catagory = await _categoryService.GetByIdAsync(id);
            if (catagory == null)
            {
                return NotFound($"Catagory not found for Id - {id}");
            }
            return Ok(catagory);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut]
        public async Task<ActionResult> UpdateCategory(UpdateCatagoryDto catagory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _categoryService.UpdateAsync(catagory);
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
            var catagory = await _categoryService.GetByIdAsync(id);

            if (catagory == null)
            {
                return NotFound();
            }
            await _categoryService.DeleteAsync(id);
            return NoContent();
        }
    }
}

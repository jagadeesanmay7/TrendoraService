using Microsoft.AspNetCore.Mvc;
using Trendora.Application.DTO.Catagory;
using Trendora.Application.Services.Interface;

namespace Trendora.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatagoryController : ControllerBase
    {
        private readonly ICatagoryService _catagoryService;

        public CatagoryController(ICatagoryService catagoryService)
        {
            _catagoryService = catagoryService;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public async Task<ActionResult> CreateCatagory([FromBody] CreateCatagoryDto catagory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity = await _catagoryService.CreateAsync(catagory);
            return Ok();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var catagory = await _catagoryService.GetAllAsync();
            return Ok(catagory);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        [Route("Details")]
        public async Task<ActionResult> GetCatagoryById(int id)
        {
            var catagory = await _catagoryService.GetByIdAsync(id);
            if (catagory == null)
            {
                return NotFound($"Catagory not found for Id - {id}");
            }
            return Ok(catagory);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut]
        public async Task<ActionResult> UpdateCatagory(UpdateCatagoryDto catagory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _catagoryService.UpdateAsync(catagory);
            return NoContent();
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete]
        public async Task<ActionResult> DeleteCatagory(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var catagory = await _catagoryService.GetByIdAsync(id);

            if (catagory == null)
            {
                return NotFound();
            }
            await _catagoryService.DeleteAsync(id);
            return NoContent();
        }
    }
}

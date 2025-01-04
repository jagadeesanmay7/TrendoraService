using Microsoft.AspNetCore.Mvc;
using Trendora.Domain.Models;
using Trendora.Infrastructure.DbContexts;

namespace Trendora.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly TrendoraDbContext _trendoraDbContext;
        public CategoryController(TrendoraDbContext trendoraDbContext)
        {
            _trendoraDbContext = trendoraDbContext;
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            _trendoraDbContext.Category.Add(category);
            _trendoraDbContext.SaveChanges();
            return Ok();
        }
    }
}

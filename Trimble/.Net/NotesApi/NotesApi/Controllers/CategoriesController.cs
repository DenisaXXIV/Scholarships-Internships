using Microsoft.AspNetCore.Mvc;

namespace NotesApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriesController : Controller
    {
        /// <summary>
        /// Get all categories
        /// </summary>
        /// <response code="200">Everything worked</response>
        /// <returns>Categories</returns>
        [HttpGet]
        public IActionResult GetCategories()
        {
            return Ok();
        }
    }
}

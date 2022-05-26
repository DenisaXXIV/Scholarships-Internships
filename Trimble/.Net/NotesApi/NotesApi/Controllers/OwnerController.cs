using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using NotesApi.Models;
using NotesApi.Services;

namespace NotesApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OwnerController : Controller
    {
        private OwnerService _ownerService;

        public OwnerController(OwnerService ownerService)
        {
            _ownerService = ownerService ?? throw new ArgumentNullException(nameof(ownerService));
        }

        /// <summary>
        /// Get all owners
        /// </summary>
        /// <returns>Owner list</returns>
        /// 
        [HttpGet]
        public async Task<IActionResult> GetOwners()
        {
            return Ok(await _ownerService.GetAll());
        }

        /// <summary>
        /// Create an owner
        /// </summary>
        /// <param name="owner"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateOwner([FromBody] Owner owner)
        {
            if (owner == null)
            {
                return BadRequest("Owner cannot be null");
            }

            await _ownerService.Create(owner);

            return Ok(await _ownerService.GetAll());
        }

        /// <summary>
        /// Update an owner
        /// </summary>
        /// <param name="id"></param>
        /// <param name="owner"></param>
        /// <returns></returns>
        /// <response code="200">Everything worked</response>
        /// <response code="404">The owner can't be created</response>
        /// <response code="400">The owner can't be null</response>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOwner([FromRoute] Guid id, [FromBody] Owner owner)
        {
            if (owner == null)
            {
                return BadRequest("Owner can't be null");
            }

            if (!await _ownerService.Update(id, owner))
            {
                return (IActionResult)CreateOwner(owner);
            }

            return Ok(_ownerService.GetAll());
        }

        /// <summary>
        /// Delete an owner
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="200">Owner deleted</response>
        /// <response code="404">The owner can't be created</response>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOwner([FromRoute] Guid id)
        {
            bool ok = await _ownerService.Delete(id);

            if (!ok)
            {
                return NotFound("Note Not Found");
            }

            return Ok("Owner deleted");
        }
    }
}

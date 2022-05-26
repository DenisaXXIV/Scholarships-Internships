using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using NotesApi.Models;
using NotesApi.Services;

namespace NotesApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private INoteCollectionService _noteCollectionService;

        public NotesController(INoteCollectionService noteCollectionService)
        {
            _noteCollectionService = noteCollectionService ?? throw new ArgumentNullException(nameof(noteCollectionService));
        }



        /// <summary>
        /// Get notes by ownerId
        /// </summary>
        /// <param name="ownerID"></param>
        /// <returns>a list of all notes</returns>
        /// <response code="200">All notes are listed</response>
        /// <response code="500">Server problems</response>
        [HttpGet("owner/{ownerID}")]
        public IActionResult GetNotes([FromRoute] Guid ownerID)
        {
            return Ok(_noteCollectionService.GetNotesByOwnerId(ownerID));
        }

        /// <summary>
        /// Get note by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>a list of all notes</returns>
        /// <response code="200">All notes are listed</response>
        /// <response code="500">Server problems</response>
        [HttpGet("note/{id}")]
        public IActionResult GetNote([FromRoute] Guid id)
        {
            return Ok(_noteCollectionService.Get(id));
        }

        /// <summary>
        /// create a note
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        [HttpPost("CreateNote")]
        public async Task<IActionResult> CreateNote([FromBody] Note note)
        {
            if (note == null)
            {
                return BadRequest("Note should not be null");
            }

            await _noteCollectionService.Create(note);

            return Ok(await _noteCollectionService.GetAll());
        }

        /// <summary>
        /// update a note
        /// </summary>
        /// <param name="id"></param>
        /// <param name="note"></param>
        /// <returns></returns>
        /// <response code="200">Everything worked</response>
        /// <response code="404">The note can't be created</response>
        /// <response code="400">The note can't be null</response>
        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateNote([FromRoute] Guid id, [FromBody] Note note)
        {

            if (note == null)
            {
                return BadRequest("Note can't be null");
            }

            if (!await _noteCollectionService.Update(id, note))
            {
                return NotFound("Note not found");
            }

            return Ok(_noteCollectionService.GetAll());
        }

        /// <summary>
        /// Delete a note
        /// </summary>
        /// <param name = "id" ></param >
        /// <returns ></returns >
        /// <response code="200">Note deleted</response>
        /// <response code="404">Note not found</response>

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteNote([FromRoute] Guid id)
        {
            bool ok = await _noteCollectionService.Delete(id);

            if (!ok)
            {
                return NotFound("Note Not Found");
            }

            return Ok("Note deleted");
        }

        ///// <summary>
        ///// Delete all notes of a given OwnerId
        ///// </summary>
        ///// <param name="ownerID"></param>
        ///// <returns></returns>
        ///// <response code="200">Notes deleted</response>
        ///// <response code="404">The notes can't be created</response>
        //[HttpDelete("delete/{ownerID}")]
        //public IActionResult DeleteNotesByOwner(Guid ownerID)
        //{
        //    List<Note> notesDeleted = _notes.FindAll(n => n.OwnerId == ownerID);

        //    if (notesDeleted.Count == 0)
        //    {
        //        return NotFound("Notes not found");
        //    }

        //    notesDeleted.ForEach(n => _notes.Remove(n));
        //    return Ok("Notes deleted");
        //}

        /// <summary>
        /// Get all notes
        /// </summary>
        /// <returns>a list of all notes</returns>
        /// <response code="200">All notes are listed</response>
        /// <response code="500">Server problems</response>
        [HttpGet]
        public async Task<IActionResult> GetNotes()
        {
            return Ok(await _noteCollectionService.GetAll());

        }
    }
}

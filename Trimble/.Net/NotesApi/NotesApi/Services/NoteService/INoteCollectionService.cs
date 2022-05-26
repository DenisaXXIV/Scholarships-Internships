using MongoDB.Bson;
using NotesApi.Models;

namespace NotesApi.Services
{
    public interface INoteCollectionService : ICollectionService<Note>
    {
        Task<List<Note>> GetNotesByOwnerId(Guid ownerId);

    }
}

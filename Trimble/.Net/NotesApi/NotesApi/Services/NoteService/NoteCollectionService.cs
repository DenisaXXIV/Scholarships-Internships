using MongoDB.Bson;
using MongoDB.Driver;
using NotesApi.Models;
using NotesApi.Settings;

namespace NotesApi.Services
{
    public class NoteCollectionService : INoteCollectionService
    {
        //private List<Note> _notes = new List<Note> { new Note { Id = new Guid("00000000-0000-0000-0000-000000000001"), CategoryId = "1", OwnerId = new Guid("00000000-0000-0000-0000-000000000001"), Title = "First Note", Description = "First Note Description" },
        //new Note { Id = new Guid("00000000-0000-0000-0000-000000000002"), CategoryId = "1", OwnerId = new Guid("00000000-0000-0000-0000-000000000001"), Title = "Second Note", Description = "Second Note Description" },
        //new Note { Id = new Guid("00000000-0000-0000-0000-000000000003"), CategoryId = "1", OwnerId = new Guid("00000000-0000-0000-0000-000000000001"), Title = "Third Note", Description = "Third Note Description" },
        //new Note { Id = new Guid("00000000-0000-0000-0000-000000000004"), CategoryId = "1", OwnerId = new Guid("00000000-0000-0000-0000-000000000001"), Title = "Fourth Note", Description = "Fourth Note Description" },
        //new Note { Id = new Guid("00000000-0000-0000-0000-000000000005"), CategoryId = "1", OwnerId = new Guid("00000000-0000-0000-0000-000000000001"), Title = "Fifth Note", Description = "Fifth Note Description" }
        //};

        private IMongoCollection<Note> _notes;

        public NoteCollectionService(IMongoDBSettings mongoDBSertiings)
        {
            var client = new MongoClient(mongoDBSertiings.ConnectionString);
            var database = client.GetDatabase(mongoDBSertiings.DatabaseName);

            _notes = database.GetCollection<Note>(mongoDBSertiings.NoteCollectionName);
        }


        public async Task<bool> Create(Note model)
        {
            model.Id = Guid.NewGuid();
            await _notes.InsertOneAsync(model);

            return true;
        }

        public async Task<bool> Delete(Guid id)
        {
            var result = await _notes.DeleteOneAsync(note => note.Id == id);

            if (!result.IsAcknowledged && result.DeletedCount == 0)
            {
                return false;
            }

            return true;
        }

        public async Task<Note> Get(Guid id)
        {
            var result = await _notes.FindAsync(note => note.Id == id);

            if (result.ToList().Count == 0)
            {
                throw new Exception("Not Found");
            }

            return result.FirstOrDefault();
        }

        public async Task<List<Note>> GetAll()
        {
            var result = await _notes.FindAsync(note => true);

            return result.ToList();
        }

        public async Task<List<Note>> GetNotesByOwnerId(Guid ownerId)
        {
            return (await _notes.FindAsync(note => note.OwnerId == ownerId)).ToList();
        }

        public async Task<bool> Update(Guid id, Note model)
        {
            model.Id = id;
            var result = await _notes.ReplaceOneAsync(note => note.Id == id, model);

            if (!result.IsAcknowledged && result.ModifiedCount == 0)
            {
                await _notes.InsertOneAsync(model);

                return false;
            }

            return true;
        }
    }
}

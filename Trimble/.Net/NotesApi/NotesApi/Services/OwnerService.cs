using MongoDB.Bson;
using MongoDB.Driver;
using NotesApi.Models;
using NotesApi.Settings;

namespace NotesApi.Services
{
    public class OwnerService : ICollectionService<Owner>
    {
        //private List<Owner> _owners = new List<Owner> { 
        //new Owner { Id = new Guid("00000000-0000-0000-0000-000000000001"), Name = "Cosmin" },
        //new Owner { Id = new Guid("00000000-0000-0000-0000-000000000002"), Name = "Constantin" },
        //new Owner { Id = new Guid("00000000-0000-0000-0000-000000000003"), Name = "Irina" },
        //new Owner { Id = new Guid("00000000-0000-0000-0000-000000000004"), Name = "Ana-Maria" },
        //new Owner { Id = new Guid("00000000-0000-0000-0000-000000000005"), Name = "Sebastian" }
        //};

        private readonly IMongoCollection<Owner> _owners;

        public OwnerService(IMongoDBSettings mongoDBSertiings)
        {
            var client = new MongoClient(mongoDBSertiings.ConnectionString);
            var database = client.GetDatabase(mongoDBSertiings.DatabaseName);

            _owners = database.GetCollection<Owner>(mongoDBSertiings.NoteCollectionName);

        }

        public async Task<bool> Create(Owner model)
        {
            await _owners.InsertOneAsync(model);
            return true;
        }

        public async Task<bool> Delete(Guid id)
        {
            var result = await _owners.DeleteOneAsync(owner => owner.Id == id);

            if (!result.IsAcknowledged && result.DeletedCount == 0)
            {
                return false;
            }

            return true;
        }

        public async Task<Owner> Get(Guid id)
        {
            var result = await _owners.FindAsync(owner => owner.Id == id);

            if (result.ToList().Count == 0)
            {
                throw new Exception("Not Found");
            }

            return result.FirstOrDefault();
        }
        public async Task<List<Owner>> GetAll()
        {
            var result = await _owners.FindAsync(owner => true);

            return result.ToList();
        }

        public async Task<bool> Update(Guid id, Owner model)
        {
            model.Id = id;
            var result = await _owners.ReplaceOneAsync(owner => owner.Id == id, model);

            if (!result.IsAcknowledged && result.ModifiedCount == 0)
            {
                await _owners.InsertOneAsync(model);

                return false;
            }

            return true;
        }
    }
}

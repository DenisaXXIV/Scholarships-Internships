using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace NotesApi.Models
{
    public class Owner
    {
        [BsonId]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "*** Name Err ***")]
        public string? Name { get; set; }
    }
}

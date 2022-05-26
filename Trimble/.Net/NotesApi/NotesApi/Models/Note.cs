using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace NotesApi.Models
{
    public class Note
    {
        [BsonId]
        [BsonIgnoreIfNull]
        public Guid? Id { get; set; } = null;

        [Required(ErrorMessage = "*** Title Err ***")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "*** Description Err ***")]
        [MinLength(10)]
        public string? Description { get; set; }

        [Required(ErrorMessage = "*** Category ID Err ***")]
        public string? CategoryId { get; set; }


        [Required(ErrorMessage = "*** OwnerId Err ***")]
        public Guid OwnerId { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace NotesApi.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "*** Name Err ***")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "*** Color Err ***")]
        public string? Color { get; set; }
    }
}

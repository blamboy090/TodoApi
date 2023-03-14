using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class TodoItemDTO
    {
        public long Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
        public string? Details { get; set; }
        public DateTime Created { get; set; }
        public int? Difficulty { get; set; }
    }
}

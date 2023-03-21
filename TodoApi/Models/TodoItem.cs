using System.Text.Json.Serialization;

namespace TodoApi.Models
{ 
    public class TodoItem
    {
        public long Id { get; set; }        
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
        public string? Secret { get; set; }
        public string? Details { get; set; }
        public DateTime Created { get; set; }
        public int? Difficulty { get; set; }
        [JsonIgnore]
        public virtual User User { get; set; }
        public int UserId { get; set; }
    }
}

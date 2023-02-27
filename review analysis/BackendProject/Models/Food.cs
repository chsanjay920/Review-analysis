using System.ComponentModel.DataAnnotations;

namespace BackendProject.Models
{
    public class Food
    {
        [Key]
        public int Id { get; set; }
        public Guid QueryId { get; set; }
        public DateTime QueryUploadedAt { get; set; }
        public string? QueryCategory { get; set; }   
        public string? restaurant { get; set; }
        public string? description { get; set; }

        public string? foodtype { get; set; }
        public string? location { get; set; }
    }
}

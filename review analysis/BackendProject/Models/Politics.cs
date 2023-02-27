using System.ComponentModel.DataAnnotations;

namespace BackendProject.Models
{
    public class Politics
    {
        [Key]
        public int Id { get; set; }

        public Guid QueryId { get; set; }
        public DateTime QueryUploadedAt { get; set; }
        public string ? QueryCategory { get; set; }
        public string? politicianName { get; set; }
        public string? party { get; set; }
        public int? age { get; set; }
        public string? qualification { get; set; }
        public string? description { get; set; }
    }
}

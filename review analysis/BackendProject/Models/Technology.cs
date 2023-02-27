using System.ComponentModel.DataAnnotations;

namespace BackendProject.Models
{
    public class Technology
    {
        [Key]
        public int Id { get; set; }

        public Guid QueryId { get; set; }
        public DateTime QueryUploadedAt { get; set; }

        public string? QueryCategory { get; set; }
        public string? gadgetname { get; set; }
        public string? description { get; set; }
        public DateTime? launchdate { get; set; }
        public int? prize { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace BackendProject.Models
{
    public class GeneralProblems
    {
        [Key]
        public int Id { get; set; }

        public Guid QueryId { get; set; }
        public DateTime QueryUploadedAt { get; set; }

        public string? QueryCategory { get; set; }
        public string? Subject { get; set; }    
        public string? Description { get; set; }    
        public string? location { get; set; }
    }
}

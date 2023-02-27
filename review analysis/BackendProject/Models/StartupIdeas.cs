using System.ComponentModel.DataAnnotations;

namespace BackendProject.Models
{
    public class StartupIdeas
    {
        [Key]
        public int Id { get; set; }

        public Guid QueryId { get; set; }
        public DateTime QueryUploadedAt { get; set; }

        public string? QueryCategory { get; set; }
        public string? title { get; set; }
        public string? description { get; set; }
        public int? investmentAmount { get; set; }  
        public string? location { get; set; }   
    }
}

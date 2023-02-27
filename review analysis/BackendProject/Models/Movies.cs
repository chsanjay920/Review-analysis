using System.ComponentModel.DataAnnotations;

namespace BackendProject.Models
{
    public class Movies
    {
        [Key]
        public int Id { get; set; }

        public Guid QueryId { get; set; }
        public DateTime QueryUploadedAt { get; set; }

        public string? QueryCategory { get; set; }
        public string? Moviename { get; set; }
        public string? MovieStory { get; set; }
        public string? cast { get;set; }
        public int? budget { get; set; }
    }
}

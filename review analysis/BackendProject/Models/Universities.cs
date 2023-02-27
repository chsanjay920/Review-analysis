using System.ComponentModel.DataAnnotations;

namespace BackendProject.Models
{
    public class Universities
    {
        [Key]
        public int Id { get; set; }

        public Guid QueryId { get; set; }
        public DateTime QueryUploadedAt { get; set; }
        public string? QueryCategory { get; set; }
        public string? Universityname { get;set; }
        public string? courseOffered { get; set; }
        public string? description { get; set; }
        public int? fee { get; set; }
        public DateTime? EstablishedYear { get; set; }
        public string? location { get; set; }

    }
}

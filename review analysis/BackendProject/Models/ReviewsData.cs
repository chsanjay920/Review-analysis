using System.ComponentModel.DataAnnotations;

namespace BackendProject.Models
{
    public class ReviewsData
    {
        [Key]
        public int Id { get; set; }
        public Guid QueryID { get; set; }
        public string review { get; set; }
        public string ?Prediction { get; set; }
        public float ?PredictionScore { get; set; }
    }
}

namespace BackendProject.Models
{
    public class FeedData
    {
        public Guid QueryId { get; set; }
        public DateTime QueryUploadedAt { get; set; }
        public string QueryCategory { get; set; }

        //food
        public string? Restaurant { get; set; }
        public string? FoodDescription { get; set; }

        public string? FoodType { get; set; }
        public string? RestaurantLocation { get; set; }

        //movie
        public string? Moviename { get; set; }
        public string? MovieStory { get; set; }
        public string? MovieCast { get; set; }
        public int? MovieBudget { get; set; }

        //GeneralPRoblems
        public string? GeneralProblemSubject { get; set; }
        public string? GeneralProblemDescription { get; set; }
        public string? GeneralProblemlocation { get; set; }
        //Politics
        public string? PoliticianName { get; set; }
        public string? PoliticalParty { get; set; }
        public int? PoliticianAge { get; set; }
        public string? PoliticianQualification { get; set; }
        public string? PoliticalDescription { get; set; }

        //startupideas
        public string? StartUpTitle { get; set; }
        public string? StartUpdescription { get; set; }
        public int? StartUpInvestmentAmount { get; set; }
        public string? StartUplocation { get; set; }
        //Technology
        public string? TechnologyName { get; set; }
        public string? TechnologyDescription { get; set; }
        public DateTime? LaunchDate { get; set; }
        public int? Prize { get; set; }
        //universities
        public string? Universityname { get; set; }
        public string? CourseOffered { get; set; }
        public string? UniversityDescription { get; set; }
        public int? UniversityFee { get; set; }
        public DateTime? EstablishedYear { get; set; }
        public string? UniversitiesLocation { get; set; }
    }
}

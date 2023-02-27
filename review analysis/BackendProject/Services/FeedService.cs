using BackendProject.DbContexts;
using BackendProject.interfaces;
using BackendProject.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BackendProject.Services
{
    public class FeedService : IFeedService
    {
        ReviewAnalysisDbContext dbContext;
        public FeedService(ReviewAnalysisDbContext db)
        {
            dbContext = db;
        }
        public List<FeedData> GetAllQueries()
        {
            var food1 = from row in dbContext.food
                        select new FeedData
                        {
                            QueryId = row.QueryId,
                            QueryUploadedAt = row.QueryUploadedAt,
                            QueryCategory = row.QueryCategory,

                            Restaurant = row.restaurant,
                            FoodDescription = row.description,
                            FoodType = row.foodtype,
                            RestaurantLocation = row.location,

                            GeneralProblemSubject = null,
                            GeneralProblemDescription = null,
                            GeneralProblemlocation = null,

                            Moviename = null,
                            MovieStory = null,
                            MovieCast = null,
                            MovieBudget = 0,

                            PoliticianName = null,
                            PoliticalParty = null,
                            PoliticianAge = 0,
                            PoliticalDescription = null,
                            PoliticianQualification = null,

                            StartUpTitle = null,
                            StartUpdescription = null,
                            StartUpInvestmentAmount = 0,
                            StartUplocation = null,

                            TechnologyName = null,
                            TechnologyDescription = null,
                            LaunchDate = null,
                            Prize = null,

                            Universityname = null,
                            CourseOffered = null,
                            UniversityDescription = null,
                            UniversityFee = null,
                            EstablishedYear = null,
                            UniversitiesLocation = null,
                        };
            var movies1 = from row in dbContext.movies
                          select new FeedData
                          {
                              QueryId = row.QueryId,
                              QueryUploadedAt = row.QueryUploadedAt,
                              QueryCategory = row.QueryCategory,

                              Restaurant = null,
                              FoodDescription = null,
                              FoodType = null,
                              RestaurantLocation = null,

                              GeneralProblemSubject = null,
                              GeneralProblemDescription = null,
                              GeneralProblemlocation = null,

                              Moviename = row.Moviename,
                              MovieStory = row.MovieStory,
                              MovieCast = row.cast,
                              MovieBudget = row.budget,

                              PoliticianName = null,
                              PoliticalParty = null,
                              PoliticianAge = 0,
                              PoliticalDescription = null,
                              PoliticianQualification = null,

                              StartUpTitle = null,
                              StartUpdescription = null,
                              StartUpInvestmentAmount = 0,
                              StartUplocation = null,

                              TechnologyName = null,
                              TechnologyDescription = null,
                              LaunchDate = null,
                              Prize = null,

                              Universityname = null,
                              CourseOffered = null,
                              UniversityDescription = null,
                              UniversityFee = null,
                              EstablishedYear = null,
                              UniversitiesLocation = null,
                          };
            var Generalproblem1 = from row in dbContext.generalProblems
                                  select new FeedData
                                  {
                                      QueryId = row.QueryId,
                                      QueryUploadedAt = row.QueryUploadedAt,
                                      QueryCategory = row.QueryCategory,

                                      Restaurant = null,
                                      FoodDescription = null,
                                      FoodType = null,
                                      RestaurantLocation = null,

                                      GeneralProblemSubject = row.Subject,
                                      GeneralProblemDescription = row.Description,
                                      GeneralProblemlocation = row.location,

                                      Moviename = null,
                                      MovieStory = null,
                                      MovieCast = null,
                                      MovieBudget = 0,

                                      PoliticianName = null,
                                      PoliticalParty = null,
                                      PoliticianAge = 0,
                                      PoliticalDescription = null,
                                      PoliticianQualification = null,

                                      StartUpTitle = null,
                                      StartUpdescription = null,
                                      StartUpInvestmentAmount = 0,
                                      StartUplocation = null,

                                      TechnologyName = null,
                                      TechnologyDescription = null,
                                      LaunchDate = null,
                                      Prize = null,

                                      Universityname = null,
                                      CourseOffered = null,
                                      UniversityDescription = null,
                                      UniversityFee = null,
                                      EstablishedYear = null,
                                      UniversitiesLocation = null,

                                  };
            var politics1 = from row in dbContext.politics
                            select new FeedData
                            {
                                QueryId = row.QueryId,
                                QueryUploadedAt = row.QueryUploadedAt,
                                QueryCategory = row.QueryCategory,

                                Restaurant = null,
                                FoodDescription = null,
                                FoodType = null,
                                RestaurantLocation = null,

                                GeneralProblemSubject = null,
                                GeneralProblemDescription = null,
                                GeneralProblemlocation = null,

                                Moviename = null,
                                MovieStory = null,
                                MovieCast = null,
                                MovieBudget = 0,

                                PoliticianName = row.politicianName,
                                PoliticalParty = row.party,
                                PoliticianAge = row.age,
                                PoliticalDescription = row.description,
                                PoliticianQualification = row.qualification,

                                StartUpTitle = null,
                                StartUpdescription = null,
                                StartUpInvestmentAmount = 0,
                                StartUplocation = null,

                                TechnologyName = null,
                                TechnologyDescription = null,
                                LaunchDate = null,
                                Prize = null,

                                Universityname = null,
                                CourseOffered = null,
                                UniversityDescription = null,
                                UniversityFee = null,
                                EstablishedYear = null,
                                UniversitiesLocation = null,

                            };
            var startup1 = from row in dbContext.startupIdeas
                           select new FeedData
                           {
                               QueryId = row.QueryId,
                               QueryUploadedAt = row.QueryUploadedAt,
                               QueryCategory = row.QueryCategory,

                               Restaurant = null,
                               FoodDescription = null,
                               FoodType = null,
                               RestaurantLocation = null,

                               GeneralProblemSubject = null,
                               GeneralProblemDescription = null,
                               GeneralProblemlocation = null,

                               Moviename = null,
                               MovieStory = null,
                               MovieCast = null,
                               MovieBudget = 0,

                               PoliticianName = null,
                               PoliticalParty = null,
                               PoliticianAge = 0,
                               PoliticalDescription = null,
                               PoliticianQualification = null,

                               StartUpTitle = row.title,
                               StartUpdescription = row.description,
                               StartUpInvestmentAmount = row.investmentAmount,
                               StartUplocation = row.location,

                               TechnologyName = null,
                               TechnologyDescription = null,
                               LaunchDate = null,
                               Prize = null,

                               Universityname = null,
                               CourseOffered = null,
                               UniversityDescription = null,
                               UniversityFee = null,
                               EstablishedYear = null,
                               UniversitiesLocation = null,

                           };
            var technology1 = from row in dbContext.technology
                              select new FeedData
                              {
                                  QueryId = row.QueryId,
                                  QueryUploadedAt = row.QueryUploadedAt,
                                  QueryCategory = row.QueryCategory,

                                  Restaurant = null,
                                  FoodDescription = null,
                                  FoodType = null,
                                  RestaurantLocation = null,

                                  GeneralProblemSubject = null,
                                  GeneralProblemDescription = null,
                                  GeneralProblemlocation = null,

                                  Moviename = null,
                                  MovieStory = null,
                                  MovieCast = null,
                                  MovieBudget = 0,

                                  PoliticianName = null,
                                  PoliticalParty = null,
                                  PoliticianAge = 0,
                                  PoliticalDescription = null,
                                  PoliticianQualification = null,

                                  StartUpTitle = null,
                                  StartUpdescription = null,
                                  StartUpInvestmentAmount = 0,
                                  StartUplocation = null,

                                  TechnologyName = row.gadgetname,
                                  TechnologyDescription = row.description,
                                  LaunchDate = row.launchdate,
                                  Prize = row.prize,

                                  Universityname = null,
                                  CourseOffered = null,
                                  UniversityDescription = null,
                                  UniversityFee = null,
                                  EstablishedYear = null,
                                  UniversitiesLocation = null,

                              };
            var university1 = from row in dbContext.universities
                              select new FeedData
                              {
                                  QueryId = row.QueryId,
                                  QueryUploadedAt = row.QueryUploadedAt,
                                  QueryCategory = row.QueryCategory,

                                  Restaurant = null,
                                  FoodDescription = null,
                                  FoodType = null,
                                  RestaurantLocation = null,

                                  GeneralProblemSubject = null,
                                  GeneralProblemDescription = null,
                                  GeneralProblemlocation = null,

                                  Moviename = null,
                                  MovieStory = null,
                                  MovieCast = null,
                                  MovieBudget = 0,

                                  PoliticianName = null,
                                  PoliticalParty = null,
                                  PoliticianAge = 0,
                                  PoliticalDescription = null,
                                  PoliticianQualification = null,

                                  StartUpTitle = null,
                                  StartUpdescription = null,
                                  StartUpInvestmentAmount = 0,
                                  StartUplocation = null,

                                  TechnologyName = null,
                                  TechnologyDescription = null,
                                  LaunchDate = null,
                                  Prize = 0,

                                  Universityname = row.Universityname,
                                  CourseOffered = row.courseOffered,
                                  UniversityDescription = row.description,
                                  UniversityFee = row.fee,
                                  EstablishedYear = row.EstablishedYear,
                                  UniversitiesLocation = row.location,
                              };

            var combinedQuery = food1.Union(Generalproblem1).Union(movies1).Union(politics1).Union(startup1).Union(technology1).Union(university1);
            return combinedQuery.ToList<FeedData>();
        }
    }
}

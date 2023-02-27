using BackendProject.interfaces;
using BackendProject.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewAnalysisController : ControllerBase
    {
        IFoodService foodService;
        IGeneralProblemService generalProblemService;
        IMoviesService moviesService;
        IPoliticsService politicsService;
        IStartUpService startUpService;
        ITechnologyService technologyService;
        IUniversityService universityService;
        IFeedService FeedService;

        public ReviewAnalysisController(
        IFoodService foodService,
        IGeneralProblemService generalProblemService,
        IMoviesService moviesService,
        IPoliticsService politicsService,
        IStartUpService startUpService,
        ITechnologyService technologyService,
        IUniversityService universityService,
        IFeedService feedService)
        {
            this.foodService = foodService;
            this.foodService = foodService;
            this.generalProblemService = generalProblemService;
            this.moviesService = moviesService;
            this.politicsService = politicsService;
            this.startUpService = startUpService;
            this.technologyService = technologyService;
            this.universityService = universityService;
            this.FeedService = feedService;
        }

        [HttpGet("GetFoodIdeas")]
        public List<Food> GetFoodIdeas()
        {
            return this.foodService.getFoodData();
        }
        [HttpPost("AddFoodIdeas")]
        public IActionResult AddFoodIdeas(Food food)
        {
            this.foodService.addFoodData(food);
            return Ok();
        }

        [HttpGet("GetGeneralProblems")]
        public List<GeneralProblems> GetGeneralProblems()
        {
            return this.generalProblemService.GetGeneralproblems();
        }
        [HttpPost("AddGeneralProblems")]
        public IActionResult AddGeneralProblems(GeneralProblems generalProblems)
        {
            this.generalProblemService.addGeneralProblem(generalProblems);
            return Ok();
        }

        [HttpGet("GetMoviesIdeas")]
        public List<Movies> GetMoviesIdeas()
        {
            return this.moviesService.GetMovies();
        }
        [HttpPost("AddMoviesIdeas")]
        public IActionResult AddMoviesIdeas(Movies movies)
        {
            this.moviesService.Addmovies(movies);
            return Ok();
        }

        [HttpGet("GetPoliticsIdeas")]
        public List<Politics> GetPoliticsIdeas()
        {
            return this.politicsService.GetPolitics();
        }
        [HttpPost("AddPoliticsIdeas")]
        public IActionResult AddPoliticsIdeas(Politics politics)
        {
            this.politicsService.AddPolitics(politics);
            return Ok();
        }

        [HttpGet("GetStartupIdeas")]
        public List<StartupIdeas> GetStartupIdeas()
        {
            return this.startUpService.GetStartupIdeas();
        }
        [HttpPost("AddStartupIdeas")]
        public IActionResult AddStartupIdeas(StartupIdeas startupIdeas)
        {
            this.startUpService.AddStartUp(startupIdeas);
            return Ok();
        }

        [HttpGet("GetTechnologyIdeas")]
        public List<Technology> GetTechnologyIdeas()
        {
            return this.technologyService.GetTechnologyList();
        }
        [HttpPost("AddTechnologyIdeas")]
        public IActionResult AddTechnologyIdeas(Technology technology)
        {
            this.technologyService.AddTechnologyService(technology);
            return Ok();
        }


        [HttpGet("GetUniversitiesIdeas")]
        public List<Universities> GetUniversitiesIdeas()
        {
            return this.universityService.GetUniversidsties();
        }
        [HttpPost("AddUniversitiesIdeas")]
        public IActionResult AddUniversitiesIdeas(Universities universities)
        {
            this.universityService.AddUniversityService(universities);
            return Ok();
        }

        [HttpGet("GetFeedData")]
        public List<FeedData> GetFeedData()
        {
            return this.FeedService.GetAllQueries();
        }

    }
}

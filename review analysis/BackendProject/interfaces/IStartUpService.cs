using BackendProject.Models;

namespace BackendProject.interfaces
{
    public interface IStartUpService
    {
        public void AddStartUp(StartupIdeas startups);
        public List<StartupIdeas> GetStartupIdeas();
    }
}

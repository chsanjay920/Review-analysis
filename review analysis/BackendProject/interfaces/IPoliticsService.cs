using BackendProject.Models;

namespace BackendProject.interfaces
{
    public interface IPoliticsService
    {
        public void AddPolitics(Politics politics);
        public List<Politics> GetPolitics();
    }
}

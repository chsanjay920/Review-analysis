using BackendProject.Models;

namespace BackendProject.interfaces
{
    public interface ITechnologyService
    {
        public void AddTechnologyService(Technology technology);
        public List<Technology> GetTechnologyList();
    }
}

using BackendProject.Models;

namespace BackendProject.interfaces
{
    public interface IUniversityService
    {
        public void AddUniversityService(Universities universities);
        public List<Universities> GetUniversidsties();
    }
}

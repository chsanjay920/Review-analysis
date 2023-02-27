using BackendProject.Models;

namespace BackendProject.interfaces
{
    public interface IGeneralProblemService
    {
        public void addGeneralProblem(GeneralProblems generalProblems);
        public List<GeneralProblems> GetGeneralproblems();
    }
}

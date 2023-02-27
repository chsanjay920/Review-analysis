using BackendProject.Models;

namespace BackendProject.interfaces
{
    public interface IFoodService
    {
        public void addFoodData(Food f);
        public List<Food> getFoodData();
    }
}

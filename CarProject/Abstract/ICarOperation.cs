using CarProject.Models;

namespace CarProject.Abstract
{
    public interface ICarOperation :IMainOperation<Car>
    {
        List<Car> GetTwoCars();
    }
}

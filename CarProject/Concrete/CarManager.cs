using CarProject.Abstract;
using CarProject.Database;
using CarProject.Models;

namespace CarProject.Concrete
{
    public class CarManager : ICarOperation
    {
        MyCarProjectDatabase Database = new();
        public void Add(Car t)
        {
            Database.Cars.Add(t);
        }

        public void Delete(int code)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return Database.Cars.ToList();
        }
   
        public void Update()
        {
            throw new NotImplementedException();
        }
        public List<Car> GetTwoCars()
        {
            throw new NotImplementedException();
        }

    }
}

namespace CarProject.Abstract
{
    public interface IMainOperation<T> where T : class
    {
        void Add(T t);
        void Delete(int code);
        void Update();
        List<T> GetAll();
    }
}

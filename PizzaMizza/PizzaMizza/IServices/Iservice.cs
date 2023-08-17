namespace PizzaMizza.IServices
{
    interface Iservice<T>
    {
        void Add(T model);
        void Delete(int id);
        List<T> GetAll();
        void Update (T model);

    }
}

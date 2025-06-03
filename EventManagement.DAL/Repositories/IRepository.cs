namespace EventManagement.DAL.Repositories;

public interface IRepository<T>
{
    void Add(T entity);
    IEnumerable<T> GetAll();
    T Get(int id);
    void Update(T entity);
    void Delete(int id);
}

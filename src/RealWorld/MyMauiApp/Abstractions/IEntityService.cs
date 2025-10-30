namespace MyMauiApp.Abstractions;

// Szablon (Interfejs generyczny)
public interface IEntityService<T>
{
    List<T> GetAll();
    T Get(int id);

    Task<List<T>> GetAllAsync();
    Task<T> GetAsync(int id);
}

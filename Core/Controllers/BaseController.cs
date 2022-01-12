namespace Core.Controllers;

public class BaseController<T> where T: class
{
    private BaseRepository<T> repository;

    public BaseController(BaseRepository<T> repository)
    {
        this.repository = repository;
    }

    public T Get(int id)
    {
        Console.WriteLine($"api ye get ({typeof(T).Name}) {id}, isteği yapıldı.");
        return repository.Get(id);
    }
}

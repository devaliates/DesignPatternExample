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

    public IList<T> GetAll()
    {
        Console.WriteLine($"api ye GetAll ({typeof(T).Name}), isteği yapıldı.");
        return repository.GetAll();
    }

    public void Add(T model)
    {
        Console.WriteLine($"api ye Add ({typeof(T).Name}), isteği yapıldı.");
        repository.Add(model);
    }

    public void Update(T model)
    {
        Console.WriteLine($"api ye Update ({typeof(T).Name}), isteği yapıldı.");
        repository.Update(model);
    }

    public void Delete(T model)
    {
        Console.WriteLine($"api ye Delete ({typeof(T).Name}), isteği yapıldı.");
        repository.Delete(model);
    }
}

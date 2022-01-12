namespace Core;

public class BaseRepository<T> where T : class
{
    public T Get(int id)
    {
        Console.WriteLine("Id bazlı veri çekildi.");
        return default;
    }
    public IList<T> GetAll()
    {
        Console.WriteLine("Tüm veriler çekildi.");
        return default;
    }
    public void Add(T model)
    {
        Console.WriteLine("Model eklendi.");
    }
    public void Delete(T model)
    {
        Console.WriteLine("Model silindi.");
    }
    public void Update(T model)
    {
        Console.WriteLine("Model güncellendi.");
    }
}

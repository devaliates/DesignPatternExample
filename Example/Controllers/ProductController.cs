using Example.Entities;
using Example.Repositories;

namespace Example.Controllers;

public class ProductController
{
    private ProductRepository productRepository;

    public ProductController()
    {
        this.productRepository = new ProductRepository();
    }

    public Product Get(int id)
    {
        Console.WriteLine($"api ye get {id} isteği yapıldı.");
        return productRepository.Get(id);
    }
}

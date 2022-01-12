using Core.Controllers;

using Example.Entities;
using Example.Repositories;

namespace Example.Controllers;

public class ProductController : BaseController<Product>
{
    public ProductController() : base (new ProductRepository())
    {
    }
}

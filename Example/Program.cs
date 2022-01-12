using Example.Controllers;

UserController userController = new UserController();

userController.Get(1);

ProductController productController = new ProductController();

productController.Get(1);


Console.Read();
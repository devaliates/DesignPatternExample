using Example.Controllers;

UserController userController = new UserController();
ProductController productController = new ProductController();


// Client Requests

userController.Get(1);
productController.Get(1);


Console.Read();
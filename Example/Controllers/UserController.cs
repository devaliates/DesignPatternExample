using Example.Entities;
using Example.Repositories;

namespace Example.Controllers;

public class UserController
{
    private UserRepository userRepository;

    public UserController()
    {
        this.userRepository = new UserRepository();
    }

    public User Get(int id)
    {
        Console.WriteLine($"api ye get {id} isteği yapıldı.");
        return userRepository.Get(id);
    }
}

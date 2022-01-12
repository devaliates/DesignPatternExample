using Core.Controllers;

using Example.Entities;
using Example.Repositories;

namespace Example.Controllers;

public class UserController : BaseController<User>
{
    public UserController() : base(new UserRepository())
    {
    }
}

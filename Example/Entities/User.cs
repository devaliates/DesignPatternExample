namespace Example.Entities;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public User()
    {
        Username = "";
        Password = "";
    }
}

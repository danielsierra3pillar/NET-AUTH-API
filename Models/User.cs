
namespace AuthApi.Models;

// Models/User.cs
public class User
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; } // In a real-world application, never store plain-text passwords
}

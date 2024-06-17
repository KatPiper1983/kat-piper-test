namespace LogInAPI.DTOs;



// This DTO is used to create a new user (POST)
public class UserDTO
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
}

// This DTO's responsibility is to create a JSON for logging in the user (GET)
public class UserLoginDTO
{
    public string Username { get; set; }
    public string Password { get; set; }
}
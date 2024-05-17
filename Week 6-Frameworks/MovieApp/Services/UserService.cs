using System.Data;

class UserService
{
    UserRepo ur = new();

    //Register
    public User? RegisterUser(User u)
    {
        //let's not let them register if the role is anything other than "user"
        if(u.Role != "user")
        {
            //reject them
            System.Console.WriteLine("Invalid Role - Please try again!");
            return null;
        }

        //let's not let them register if the username is already taken
        //Get all users
        List<User> allUsers = ur.GetAllUsers();
        //Check if our new username matches any of the usernames on all those users
        foreach(User user in allUsers)
        {
            if(user.Username == u.Username)
            {
                System.Console.WriteLine("Username already taken! - Please try again1");
                return null; //reject them
            }
        }

        //IF we make it this far, then we are saying that the role is good to go
        //and the username is good to go

        //If we don't care about any validation - this is but a simple/trivial service method
        return ur.AddUser(u);
    }

    //Login
    public User? Login(string username, string password)
    {
        //Get all users
        List<User> allUsers = ur.GetAllUsers();
        //check each one to see if we find a match
        foreach(User user in allUsers)
        {
            //if matching username and password, they 'login' -> return that user
            if(user.Username == username && user.Password == password)
            {
                //Yay! Login!
                return user; //us returning the user will indicate success
            }
          
        }
        //If we make it this far - we didn't find a match! oh no!
        System.Console.WriteLine("Invalid Username/Password combo! Please try again");
        return null; //reject the login

    }
}
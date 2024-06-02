using Microsoft.Data.SqlClient;

class UserRepo
{
    private readonly string _connectionString;

    //Dependency Injection -> Constructor Injection
    public UserRepo(string connString)
    {
        _connectionString = connString;
    }
    //add, get-one, get-all, update, and delete
    public User AddUser(User u)
    {
        //set up DB connection
        using SqlConnection connection = new(_connectionString);
        connection.Open();

        //Create the SQL String
        string sql = "INSERT INTO dbo.[User] OUTPUT inserted.* VALUES (@Username, @Password, @Role)";

        //Set up SqlCommand Object and use its methods to modify the Parameterized Values
        using SqlCommand cmd = new(sql, connection);
        cmd.Parameters.AddWithValue("@Username", u.Username);
        cmd.Parameters.AddWithValue("@Password", u.Password);
        cmd.Parameters.AddWithValue("@Role", u.Role);

        //Execute the query
        //cmd.ExecuteNonQuery();//This executes a non-select SQL statement (inserts, updates, deletes etc)
        using SqlDataReader reader = cmd.ExecuteReader();

        //Extract the results
        if(reader.Read())
        {
            //If Read() found data -> then extract it
            User newUser = BuildUser(reader); //helper method
            
            return newUser;
        }
        else
        {
            //Else Read() found nothing -> Insert Failed
            return null;
        }


    }
    public User GetUser(int id)
    {
        return null;
    }
    public List <User>? GetAllUsers()
    {
        List<User> users = [];
        try
        {
            //Set up DB connection
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            //Create the SQL String
            string sql = "SELECT * FROM dbo.[User]";

            //Set up SqlCommand Object
            using SqlCommand cmd = new(sql, connection);

            //Execute the Query
            using var reader = cmd.ExecuteReader(); //flexing options here with the use of var

            //Extract the Results
            while(reader.Read())
            {
                //for each iteration -> extract 
                User newUser = BuildUser(reader);
               

                //don't return- instead add to list
                users.Add(newUser);
            }
            return users;
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.StackTrace);
            return null;
        }
      
       
    }
    public User UpdateUser(User updatedUser)
    {
       return null;
    }
    public User DeleteUser(User u)
    {
        return null;
    }

    //Helper Method
    private User BuildUser(SqlDataReader reader)
    {
        User newUser = new();
        newUser.Id = (int)reader["Id"];
        newUser.Username = (string)reader["Username"];
        newUser.Password = (string)reader["Password"];
        newUser.Role = (string)reader["Role"];

        return newUser;
    }
}

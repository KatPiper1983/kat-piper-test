/*
Coding to Interfaces - practice wherein we will start these "classes" that are functionality focused (Repos, Services, Controllers)
we will opt to Outline their Functionality through an Interface first

The overall goal is to promote Flexibility/Reusability
If ever need to change implementations, you can simply create new class 
that implements the SAME Interface therby letting us know that it will 
service all the same INTENTIONS


*/

interface IUserRepo
{
    public void AddUser(User u);
    public User? GetUser(int id);
    public List<User> GetAllUsers();
    public void UpdateUser(User u);
    public void DeleteUser(int id);
    public void Save();
}
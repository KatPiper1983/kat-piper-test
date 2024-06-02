using System.Runtime;

//Entity Framework requires us to 

namespace EfCoreExample.Models
{
    //this file is holding our one to one relationship
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        //establishes one to one relationship with other entity by creating dependency w/in it
        public Profile Profile { get; set; }
    }

    public class Profile
    {
        public int ProfileId { get; set; }
        public string Bio { get; set; }
        public int UserId {get; set;}
        public User User { get; set; }

    }

}
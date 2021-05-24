using System.Collections.Generic;

namespace sw_studio_project.Models{
    public class User{
        public string firstName {get; set;}
        public string lastName {get; set;}
        public string username {get; set;}
        public string password {get; set;}
        public string role {get; set;}
        public bool blacklisted {get; set;}

        public User(){

        }
    }

    public class Users{
        public List<User> users {get; set;}
    }
}

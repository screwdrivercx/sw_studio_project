using System.Collections.Generic;

namespace sw_studio_project.Models{
    public class Room{
        public string name {get; set;}
        public int number {get; set;}
    }

    public class Root{
        public List<Room> rooms {get; set;}
    }
}

using System;
using System.Text.Json.Serialization;


 namespace EternalQuest
{
    public abstract class Goal
    {
        public string Name {get; set;}
        public string Description {get; set;}
        public int Points {get; set;}
        public bool IsComplete {get; set;}

        public Goal (string name, string description, int points)

        {
            Name = name;
            Description = description;
            Points = points;
            UIsComplete = false;

        }

        public abstract int RecordEvent()

        public visrual string GetDetailsString()
        {
            string status = IsComplete ? "{x}" : "{}";
            return $"{status} {Name}: {Description}";

        }
        public Goal(){}
        
        
        }
        
    }
}   

}
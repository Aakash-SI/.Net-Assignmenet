using System;
using System.Collections.Generic;
using System.Linq;

namespace SportzClubManagement
{
    class Athlete
    {
        public int Athlete_Id { get; private set; }
        public string First_Name { get; }
        public string Last_Name { get; }
        public int Age { get; }
        public string Sport { get; }
        public DateTime Registration_Date { get; }

        private static int next_Athlete_Id = 1;

        public Athlete(string first_Name, string last_Name, int age, string sport, DateTime registration_Date)
        {
            Athlete_Id = next_Athlete_Id++;
            First_Name = first_Name;
            Last_Name = last_Name;
            Age = age;
            Sport = sport;
            Registration_Date = registration_Date;
        }
    }

    class Event
    {
        public int Event_Id { get; private set; }
        public string Event_Name { get; }
        public string Event_Type { get; }
        public DateTime Event_Date { get; }

        private static int nextEventId = 1;

        public Event(string event_Name, string event_Type, DateTime event_Date)
        {
            Event_Id = nextEventId++;
            Event_Name = event_Name;
            Event_Type = event_Type;
            Event_Date = event_Date;
        }
    }

    class Sportz_Club
    {
        private List<Athlete> athletes;
        private List<Event> events;

        public Sportz_Club()
        {
            athletes = new List<Athlete>();
            events = new List<Event>();
        }

        public void Register_Athlete(Athlete athlete)
        {
            athletes.Add(athlete);
        }

        public Athlete GetAthlete(int athleteId)
        {
            return athletes.FirstOrDefault(a => a.AthleteId == athleteId);
        }

        public void Create_Event(Event newEvent)
        {
            events.Add(newEvent);
        }

        public Event GetEvent(int eventId)
        {
            return events.FirstOrDefault(e => e.EventId == eventId);
        }

        // Other methods for performance tracking and data analysis can be added here
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sportz_Club club = new Sportz_Club();

            Athlete a1 = new Athlete("John", "Doe", 25, "Basketball", new DateTime(2023, 1, 15));
            Athlete a2 = new Athlete("Jane", "Smith", 30, "Soccer", new DateTime(2023, 2, 10));
            club.Register_Athlete(a1);
            club.Register_Athlete(a2);

            Event e1 = new Event("Basketball Tournament", "Tournament", new DateTime(2023, 3, 20));
            Event e2 = new Event("Soccer Practice", "Practice", new DateTime(2023, 3, 25));
            club.Create_Event(e1);
            club.Create_Event(e2);

            Athlete retrive_a = club.GetAthlete(1);
            Event retrive_r = club.GetEvent(1);

            if (retrive_a != null)
            {
                Console.WriteLine($"Athlete: {retrive_a.First_Name} {retrive_a.Last_Name}");
            }
            else
            {
                Console.WriteLine("Athlete not found.");
            }

            if (retrive_r != null)
            {
                Console.WriteLine($"Event: {retrive_r.Event_Name}");
            }
            else
            {
                Console.WriteLine("Event not found.");
            }
        }
    }
}

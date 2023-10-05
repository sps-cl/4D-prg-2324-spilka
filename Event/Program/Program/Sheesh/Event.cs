using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Event
    {
        public string event_name;
        public string event_date;
        public List<Attendee> list_of_attendees = new List<Attendee>();
        public List<string> attendee_role = new List<string>();

        public Event(string event_name, string event_date)
        {
            this.event_name = event_name;
            this.event_date = event_date;

            EventManager eventManager = new EventManager();
            eventManager.AddEvent(this);
        }

        public void DisplayInfo(){
            Console.WriteLine("-----EVENT-----");
            Console.WriteLine("Jméno: "+event_name);
            Console.WriteLine("Datum: "+event_date);
            Console.WriteLine("Seznam účastníků: ");
            for (int i = 0; i < list_of_attendees.Count; i++)
            {
                Console.WriteLine("    - "+list_of_attendees[i].attendee_name + " (" + attendee_role[i] + ")");
            }
        }
    }
}

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
        public List<string> attendees_info = new List<string>();

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
            for (int i = 0; i < attendees_info.Count; i++)
            {
                Console.WriteLine("    - "+attendees_info[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class EventManager
    {
        public static List<Event> list_of_events = new List<Event>();

        public void AddEvent(Event _event){
            list_of_events.Add(_event);
        }

        public void AddToEvent(string _event_name, Attendee attendee){
            for (int i = 0; i < list_of_events.Count; i++)
            {
                if(_event_name == list_of_events[i].event_name){
                    list_of_events[i].list_of_attendees.Add(attendee);
                }
            }
        }
    }
}

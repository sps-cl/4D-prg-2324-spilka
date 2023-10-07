using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventApp.Exceptions;

namespace Program
{
    class EventManager
    {
        public static List<Event> list_of_events = new List<Event>();

        public void AddEvent(Event _event){
            list_of_events.Add(_event);
        }

        public void AddToEvent<T>(string _event_name, Attendee<T> attendee){
            for (int i = 0; i < list_of_events.Count; i++)
            {
                if(_event_name == list_of_events[i].event_name){
                    switch (attendee)
                    {
                        case Guest guest:
                            list_of_events[i].attendees_info.Add(guest.attendee_name);
                            break;

                        case Performer performer:
                            list_of_events[i].attendees_info.Add(performer.attendee_name + ", job: " + performer.job);
                            break;

                        default:
                            throw new AttendeeNotFoundException();
                    }
                } else {
                    throw new CantAddToEvent();
                }
            }
        }
    
        public void RemoveFromEvent<T>(string _event_name, Attendee<T> attendee){
            for (int i = 0; i < list_of_events.Count; i++)
            {
                if(_event_name == list_of_events[i].event_name){
                    switch (attendee)
                    {
                        case Guest guest:
                            list_of_events[i].attendees_info.Remove(guest.attendee_name);
                            break;

                        case Performer performer:
                            list_of_events[i].attendees_info.Remove(performer.attendee_name + ", job: " + performer.job);
                            break;

                        default:
                            throw new AttendeeNotFoundException();
                    }
                } else {
                    // error event nevytvoren
                    Console.WriteLine("Z eventu \"" + _event_name + "\", nelze odebrat \"" + attendee.attendee_name + "\"(" + attendee.GetType().Name + ")");
                }
            }
        }

    }
}

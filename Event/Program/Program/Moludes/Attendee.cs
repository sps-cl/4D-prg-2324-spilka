using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    abstract class Attendee<T>
    {
        public string attendee_name;

        public Attendee(string attende_name){
            this.attendee_name = attende_name;
        }

        public void AddMeToEvent(string _event_name){
            EventManager event_manager = new EventManager();
            event_manager.AddToEvent(_event_name, this);
        }

        public void RemoveMeFromEvent(string _event_name){
            EventManager event_manager = new EventManager();
            event_manager.RemoveFromEvent(_event_name, this);
        }
    }
}

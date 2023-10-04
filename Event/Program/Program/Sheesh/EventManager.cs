using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class EventManager
    {
        List<Event> list_of_events = new List<Event>();

        void AddEvent(Event _event){
            list_of_events.Add(_event);
        }
    }
}

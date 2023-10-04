using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Event
    {
        string event_name;
        string event_date;

        public Event(string event_name, string event_date)
        {
            this.event_name = event_name;
            this.event_date = event_date;

            //EventManager.AddEvent();
        }


    }
}

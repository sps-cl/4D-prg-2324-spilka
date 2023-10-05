using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    abstract class Attendee
    {
        public string attendee_name;
        public string event_name;

        public Attendee(string attende_name, string event_name){
            this.attendee_name = attende_name;
            this.event_name = event_name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Performer : Attendee
    {
        public Performer(string attende_name, string event_name) : base(attende_name, event_name)
        {
            
        }
    }
}

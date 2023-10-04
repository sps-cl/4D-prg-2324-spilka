using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Guest : Attendee
    {
        public Guest(string attende_name, string event_name) : base(attende_name, event_name)
        {
            
        }
    }
}

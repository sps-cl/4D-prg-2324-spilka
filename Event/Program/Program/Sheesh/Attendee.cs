using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    abstract class Attendee
    {
        public string attende_name;
        public string event_name;

        public Attendee(string attende_name, string event_name){
            this.attende_name = attende_name;
            this.event_name = event_name;

            CheckIfEventExists(event_name);
        }

        void CheckIfEventExists(string event_name){
            
            //zda event existuje
            
        }
    }
}

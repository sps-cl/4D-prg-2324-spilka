using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Guest : Attendee<Guest>
    {
        public Guest(string attende_name) : base(attende_name)
        {

        }
    }
}

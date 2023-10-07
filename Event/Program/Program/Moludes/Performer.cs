using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Performer : Attendee<Performer>
    {
        public string job;

        public Performer(string attende_name, string job) : base(attende_name)
        {
            this.job = job;
        }
    }
}

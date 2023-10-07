using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Event event1 = new Event("Svatba", "01.02.2009");

            Guest guest1 = new Guest("Radek Spilka");
            guest1.AddMeToEvent("Svatba");
            Guest guest2 = new Guest("Imposter");
            guest2.AddMeToEvent("Svatba");
            Performer performer1 = new Performer("Jakub Not Talman", "Trash Talking");
            performer1.AddMeToEvent("Svatba");

            event1.DisplayInfo();

            guest2.RemoveMeFromEvent("Svatba");

            event1.DisplayInfo();

            Console.ReadLine();
        }
    }
}
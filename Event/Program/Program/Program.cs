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
            Event event2 = new Event("Hodina programování", "01.02.2009");

            Guest guest1 = new Guest("Radek Spilka", "Hodina programování");
            Guest guest2 = new Guest("Pepa Novak", "Hodina programování");

            event2.DisplayInfo();

            Console.ReadLine();
        }
    }
}
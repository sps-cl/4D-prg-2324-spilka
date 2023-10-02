using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.models;

namespace Library.models
{
    internal class DVD : LibraryItem<DVD>
    {
        public string Director;

        public DVD(string Director, int id, string title) : base(id, title)
        {
            this.Director = Director;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Director: " + Director);
        }
    }
}

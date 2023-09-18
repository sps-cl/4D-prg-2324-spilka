using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.models;

namespace Library.models
{
    internal class Book : LibraryItem<Book>
    {
        public int NumberOfPages;
        public string Author;
        
        public Book(int NumberOfPages, string Author, int id, string title) : base(id, title)
        {
            this.NumberOfPages = NumberOfPages;
            this.Author = Author;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Author: " + Author + ". NumberOfPager: " + NumberOfPages);
        }
    }
}

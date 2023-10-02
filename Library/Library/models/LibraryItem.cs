using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.models
{
    abstract class LibraryItem<T>
    {
        public int Id { get; }
        public string Title { get; }
        public bool IsAvailable { get; set; }

        public LibraryItem(int id, string title) {
            this.Id = id;
            this.Title = title;
            this.IsAvailable = true;
        }    

        public abstract void DisplayInfo();
    }
}

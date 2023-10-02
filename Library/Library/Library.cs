using Library.models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Exception;

namespace Library
{
    internal class Library<T> where T : LibraryItem<T>
    {
        List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public void CheckOutItem(int id)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Id != null)
                {
                    if (items[i].Id == id && items[i].IsAvailable)
                    {
                        Console.WriteLine("Vypujcil jsi si item s Id: " + items[i].Id);
                        items[i].IsAvailable = false;
                    }
                    else
                    {
                        Console.WriteLine("Nelze odebrat item s Id: " + items[i].Id);
                        // not available
                    }
                } else
                {
                    // not found
                }


            }
        }

        public void ListItems()
        {
            Console.WriteLine("Veci v knihovne");
            foreach (var item in items)
            {
                item.DisplayInfo();
            }
        }
    }
}

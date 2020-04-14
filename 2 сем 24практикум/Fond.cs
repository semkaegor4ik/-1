using System;
using System.Collections.Generic;
using System.Text;

namespace _2_сем_24практикум
{
    class Fond
    {
        List<Book> list = new List<Book>();
        StringBuilder info = new StringBuilder("Some information");
        public Fond() { }

        public void AddElem(Book other)
        {
            list.Add(other);
        }

        public void DeleteInfo()
        {
            info.Clear();
        }

        public void AddInfo(String s)
        {
            info.Append(";\n" + s);
        }

        public void ShowBooks()
        {
            foreach(Book book in list)
            {
                Console.WriteLine(book);
            }
        }
        public void ShowAuthorBooks(String name)
        {
            foreach (Book book in list)
            {
                if(String.Equals(book.Author, name))
                    Console.WriteLine(book);
            }
        }
    }
}

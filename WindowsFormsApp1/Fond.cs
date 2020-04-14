using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1
{
    class Fond
    {
        private List<Book> list = new List<Book>();
        private StringBuilder info = new StringBuilder();
        public void AddElem(Book other)
        {
            list.Add(other);
        }

        public bool DeleteElem(Book other)
        {
            if (list.Contains(other))
            {
                list.Remove(other);
                return true;
            }
            else
                return false;
        }
        public void DeleteInfo()
        {
            info.Clear();
        }

        public void AddInfo(String s)
        {
            if(info.Length!=0)
                info.Append("; ");
            info.Append("" + s);
        }

        public List<Book> ShowBooks()
        {
            List<Book> k = new List<Book>();
            foreach (Book book in list)
            {
                k.Add(book);
            }
            return k;
        }
        public List<Book> ShowAuthorBooks(String name)
        {
            List<Book> k = new List<Book>();
            foreach (Book book in list)
            {
                if(String.Equals(book.Author, name))
                    k.Add(book);
            }
            return k;
        }

        public String getInfo()
        {
            return info.ToString();
        }
    }
}

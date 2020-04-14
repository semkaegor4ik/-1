using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _2_сем_24практикум
{
    class Book
    {
        private String name;
        private String author;

        public Book(string name, string author)
        {
            this.name = name;
            this.author = author;
        }

        public override string ToString()
        {
            return " Автор: " + author + "Название: " + name;
        }

        public String Name
        {
            get
            {
                return name;
            }
        }

        public String Author
        {
            get
            {
                return author;
            }
        }
    }
}

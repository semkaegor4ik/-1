using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace WindowsFormsApp1
{
    class Book
    {
        private String name;
        private String author;

        public Book(string name, string author)
        {
            
            this.name = DeleteSpaces(name);
            this.author = DeleteSpaces(author);
        }

        public override string ToString()
        {
            return " Автор: " + author + "  Название: " + name;
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



        private String DeleteSpaces(String s)
        {
            int i = 0;
            while(s[i]==' ')
            {
                s = s.Remove(i,1);
                i++;
            }
            i = s.Length;
            while (s[i-1] == ' ')
            {
                s = s.Remove(i,1);
                i--;
            }
            return s;
        }

        public override bool Equals(object obj)
        {
            return obj is Book book &&
                   name == book.name &&
                   author == book.author &&
                   Name == book.Name &&
                   Author == book.Author;
        }

        public override int GetHashCode()
        {
            int hashCode = 417524824;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(author);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Author);
            return hashCode;
        }
    }
}

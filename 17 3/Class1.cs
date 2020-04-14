using System;
using System.Linq;
using System.IO;
namespace Example
{
    class Rectangle
    {
        private int a, b;
        public Rectangle(int a, int b)
        {
            if (a < 1 || b < 1)
            {
                throw new Exception("Недопустимые длины сторон");
            }
            else
            {
                this.a = a;
                this.b = b;
            }
        }
        public void Show()
        {
            Console.WriteLine("стороны прямоугольника: {0}X{1}", a, b);
        }

        public int Perimetr()
        {
            return 2 * (a + b);
        }
        public int Square()
        {
            return a * b;
        }
        public bool Quadrate
        {
            get
            {
                if (a == b)
                    return true;
                else
                    return false;
            }
        }
        public Rectangle ABleng                 //сразу две стороны
        {
            get
            {
                return new Rectangle(a, b);
            }
            set
            {
                a = value.a;
                b = value.b;
            }
        }
        public int Aleng                 //первая сторона
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public int Bleng                 //вторая сторона
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }

        public int this[int c]
        {
            get
            {
                if (c == 1)
                    return b;
                else if (c == 0)
                    return a;
                else
                    throw new Exception("Недопустимый индекс");
            }
           
        }
        public static Rectangle operator ++(Rectangle a)
        {
            return new Rectangle(++a.a, ++a.b);
        }
        public static Rectangle operator --(Rectangle a)
        {
            return new Rectangle(--a.a, --a.b);
        }
        public static Rectangle operator *(Rectangle a, int c)
        {
            return new Rectangle(a.a * c, a.b * c);
        }
        public static Rectangle operator *(int c, Rectangle a)
        {
            return new Rectangle(a.a * c, a.b * c);
        }
    }
}
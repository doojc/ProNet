using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with Conversions ***\n");

            // Make a rectangle.
            Rectangle r = new Rectangle(15, 4);

            Console.WriteLine(r.ToString());
            r.Draw();

            Console.WriteLine();

            // Convert r into a Square, based on the height of the Rectangle.
            Square s = (Square)r;
            Console.WriteLine(s.ToString());
            s.Draw();

            // Converting an int to a Square.   
            Square sq2 = (Square)90;   
            Console.WriteLine("sq2 = {0}", sq2);  

            // Converting a Square to an int.   
            int side = (int)sq2;   
            Console.WriteLine("Side length of sq2 = {0}", side);   

            Console.ReadLine();
        }

        public struct Rectangle
        {
            public int Width { get; set; }
            public int Height { get; set; }

            public Rectangle(int w, int h) : this()
            {
                Width = w;
                Height = h;
            }

            public void Draw()
            {
                for (int i = 0; i < Height; i++)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            public override string ToString()
            {
                return string.Format("[Width: {0}; Height = {1}]",
                    Width, Height);
            }
        }

        public struct Square
        {
            public int Length { get; set; }

            public Square(int l) : this()
            {
                Length = l;
            }

            public void Draw()
            {
                for (int i = 0; i < Length; i++)
                {
                    for (int j = 0; j < Length; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            public override string ToString()
            {
                return string.Format("[Lenght = {0}]", Length);
            }

            // Rectangles can be explicitly converted into Squares
            public static explicit operator Square(Rectangle r)
            {
                Square s = new Square();
                s.Length = r.Height;
                return s;
            }

            public static explicit operator Square ( int sideLength)
            {
                Square newSq = new Square();
                newSq.Length = sideLength;
                return newSq;
            }

            public static explicit operator int ( Square s)
            {
                return s.Length;
            }
        }
    }
}

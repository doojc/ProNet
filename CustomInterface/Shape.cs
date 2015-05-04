using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    abstract class Shape
    {
        public Shape(string name = "NoName")
        { PetName = name; }

        public string PetName { get; set; }

        //public virtual void Draw()
        //{
        //    Console.WriteLine("Inside Shape.Draw()");
        //}

        public abstract void Draw();
    }
}

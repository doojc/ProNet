using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun with Interfaces ***\n");

            Hexagon hex = new Hexagon();
            Console.WriteLine("Points: {0}", hex.Points);

            Circle c = new Circle("Lisa");
            IPointy itfPt = null;

            try
            {
                itfPt = (IPointy)c;
                Console.WriteLine(itfPt.Points);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);                
            }

            // Can we treat hex2 as IPointy?
            Hexagon hex2 = new Hexagon("Peter");
            IPointy itfPt2 = hex2 as IPointy;

            if(itfPt2 != null)
                Console.WriteLine("Points: {0}", itfPt2.Points);
            else
                Console.WriteLine("OOPS! Not pointy...");

            // Make an array of shapes
            Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Zoe"), new Circle("JoJo"), new ThreeDCircle() };

            for (int i = 0; i < myShapes.Length; i++)
            {
                myShapes[i].Draw();

                // Who's pointy?
                if (myShapes[i] is IPointy)
                    Console.WriteLine("->Points: {0}", ((IPointy) myShapes[i]).Points);
                else
                    Console.WriteLine("->{0}\'s not pointy!", myShapes[i].PetName);

                // Can I draw you in 3D?
                if (myShapes[i] is IDraw3D)
                    DrawIn3D((IDraw3D)myShapes[i]);
                
                Console.WriteLine();
            }

            // Get first pointy item.
            IPointy firstPointyItem = FindFirstPointyShape(myShapes);
            if(firstPointyItem != null)
                Console.WriteLine("The item {0} has {1} points", firstPointyItem.GetType().Name, firstPointyItem.Points);

            Console.ReadLine();
        }

        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type");
            itf3d.Draw3D();
        }

        // This method returns the first object in the array that implements IPointy
        static IPointy FindFirstPointyShape(Shape[] shapes)
        {
            foreach (Shape s in shapes)
            {
                if (s is IPointy)
                    return s as IPointy;
            }

            return null;
        }
    }
}

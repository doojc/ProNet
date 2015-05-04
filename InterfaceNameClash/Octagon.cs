using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        // Explicitly bind Draw() implementations to a given interface
        void IDrawToForm.Draw()
        {
            // Shared drawing logic
            Console.WriteLine("Drawing the Octagon to form...");
        }
        void IDrawToMemory.Draw()
        {
            // Shared drawing logic
            Console.WriteLine("Drawing the Octagon to memory...");
        }
        void IDrawToPrinter.Draw()
        {
            // Shared drawing logic
            Console.WriteLine("Drawing the Octagon to printer...");
        }


    }
}

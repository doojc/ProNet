using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Garage
    {
        // The hidden int backing field is set to zero!
        public int NumberofCars { get; set; }

        // The hidden Car backing field is set to null!
        public Car MyAuto { get; set; }

        // Must use constructors to override default
        // values assigned to hidden backing fields.
        public Garage()
        {
            MyAuto = new Car();
            NumberofCars = 1;
        }

        public Garage(Car car, int number)
        {
            MyAuto = car;
            NumberofCars = number;
        }
    }
}

﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    public class Garage : IEnumerable
    {
        private Car[] carArray = new Car[4];

        // Fill with some Car objects upon startup
        public Garage()
        {
            carArray[0] = new Car("Rusty", 30);
            carArray[1] = new Car("Clunker", 55);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);
        }

        public IEnumerator GetEnumerator()
        {
            return carArray.GetEnumerator();
        }

        public IEnumerable GetTheCars(bool ReturnReversed)
        {
            if (ReturnReversed)
            {
                for(int i = carArray.Length; i != 0; i--)
                {
                    yield return carArray[i - 1];
                }
            }
            else
            {
                foreach (Car c in carArray)
                {
                    yield return c;
                }
            }
        }
    }
}

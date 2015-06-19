﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLotConnectedLayer
{
    public class NewCar
    {
        public int CarID { get; set; }
        public string Color { get; set; }
        public string Make { get; set; }
        public string PetName { get; set; }

        public NewCar() { }
        public NewCar(int id, string color, string make, string petName)
        {
            CarID = id;
            Color = color;
            Make = make;
            PetName = petName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    class Vehicle
    {
        public string Brand { get; set; }
        
        public Vehicle(string brand)
        {
            Brand = brand;
        }
    }

    class Car : Vehicle
    {
        public string Model { get; set; }
        public Car(string brand, string model) : base(brand)
        {
            Model = model;
        }
    }
}

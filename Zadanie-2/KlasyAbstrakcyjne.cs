using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    abstract class Shape
    {
        public abstract void CalculateArea();
    }

    class Circle : Shape
    {
        public double promien {  get; set; }
        public Circle(double promien)
        {
            this.promien = promien;
        }
        public override void CalculateArea()
        {
            const double PI = 3.14;
            double res = PI * Math.Pow(promien, 2);
            Console.WriteLine("Pole koła wynosi: "+res);
        }
    }

    class Rectangle : Shape
    {
        public double a { get; set; }
        public double b { get; set; }
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override void CalculateArea()
        {
            double res = a * b;
            Console.WriteLine("Pole prostokąta wynosi: "+res);
        }
    }
}

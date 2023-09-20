using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    class Kalkulator
    {
        public void Addition(int num1, int num2)
        {
            int res;
            res = num1 + num2;
            Console.WriteLine("Wynik dodawania: " +res);
        }

        public void Subtraction(int num1, int num2)
        {
            int res;
            res = num1 - num2;
            Console.WriteLine("Wynik odejmowania: " + res);
        }

        public void Multiplication(int num1, int num2)
        {
            int res;
            res = num1 * num2;
            Console.WriteLine("Wynik mnożenia: " + res);
        }
        public void Division(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Nie można dzielić przez 0.");
            }
            else
            {
                int res;
                res = num1 / num2;
                Console.WriteLine("Wynik dzielenia: " + res);
            }

        }

    }

}

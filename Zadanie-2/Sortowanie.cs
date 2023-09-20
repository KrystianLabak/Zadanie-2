using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    class Sortowanie : IComparable<Sortowanie>
    {
        public int Liczba {  get; set; }
        public Sortowanie(int liczba)
        {
            Liczba = liczba;
        }

        public int CompareTo(Sortowanie other)
        {
            return Liczba.CompareTo(other.Liczba);
        }
    }
}

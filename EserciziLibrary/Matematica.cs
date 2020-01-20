using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziLibrary
{
    public class Matematica
    {
        public static long CalcolaFattoriale(int n)
        {
            if (n == 0)
                return 1;
            return n * CalcolaFattoriale(n - 1);
        }
        public static int MaggioreTra(int a, int b, int c)
        {
            if (a > b && b > c)
                return a;
            if (b > a && b > c)
                return b;
            return c;
        }
        public static int MinoreTra(int a, int b, int c)
        {
            if (a < b && b < c)
                return a;
            if (b < a && b < c)
                return b;
            return c;
        }
        public static double Inverso(double d)
        {
            return 1 / d;
        }
    }
}

using System;

namespace Chess
{
    class Program
    {
         public static bool Suitable(string a)
        {
            if (a[0] >= 'A' && a[0] <= 'H' && a[1] >= '1' && a[1] <= '8' && a.Length == 2)
                return true;
            else
                return false;

        }
        static void Main(string[] args)
        {
            char[,] board = new char[8, 8];
        }
    }
}

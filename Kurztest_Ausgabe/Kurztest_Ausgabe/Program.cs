using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kurztest_Ausgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Berechnen(i));

            }
        }

        
        public static int Berechnen(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;

            }
            return a;

        }
        
    
    }
    
}




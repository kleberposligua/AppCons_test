﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCons_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo c#");
            Console.WriteLine("Pulse una tecla para continuar...");
            

            //bucle for
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("Hola {0}", i);
            }
            Console.ReadKey();

            //bucle for 2
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Saludos {0}", i);
            }
            Console.ReadKey();

            //bucle while en rama nueva
            int j = 0;
            while (j<10)
            {
                j++;
                Console.WriteLine("Nueva línea {0}", j);
            }

            //condicionales
            int a = 10, b = 100;
            if (a > b)
                Console.WriteLine("Hola");
        }
    }
}

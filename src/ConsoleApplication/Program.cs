//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            var train = new Train("azul");
            train.StartEngines();
            Console.WriteLine("Hello World!");

            Train t1 = new Train("Last Train To London");
            Train t2 = new Train("Last Train To London");
            Train t3 = new Train("RunAway Train");
            Console.WriteLine($" t1==t2 --> {t1==t2}");
            Console.WriteLine($" t2==t3 --> {t2==t3}");

           for(int i=0; i<100; i++)
           {
               Train train1 = new Train("100");
           }
            Console.WriteLine(Train.Contador());
          //for (int i=0; i<=10000000; i++)
          //{
              //Train train2 = new Train("10.000.000");
          //}


        }
    }
}
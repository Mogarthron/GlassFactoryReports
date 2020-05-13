using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        List<tOxide> oxide = new List<tOxide>() 
        {
            new tOxide("SiO2", 60.08f, 2.28f),
            new tOxide("Na2O", 61.9789f, 3.1f),
            new tOxide("CaO", 56.0774f, 3.9f),
            new tOxide("K2O", 94.2f, 2.8f)
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in Console");
            
        }
    }
}

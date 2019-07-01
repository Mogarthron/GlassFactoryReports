using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLogic logic = new BusinessLogic();

            logic.PrintWTComposition(logic);
           
            Console.ReadLine();
        }

        
    }
}

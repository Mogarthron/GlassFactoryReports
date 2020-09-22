using System;

namespace CommandLineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLogic logic = new BusinessLogic();       

            Console.Write("Użytkownik: ");
            string user = Console.ReadLine();           

            logic.Login(user);
        }
    }
}

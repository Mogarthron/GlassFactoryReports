using System;
using System.Collections.Generic;
using System.Text;
using CommandLineApp.Controlls;
using Core3Library.Querys;

namespace CommandLineApp
{
    class BusinessLogic
    {        
        string _user;

        int incorrectPwdEntris = 0;

        string password = "123";

        public void Login(string user)
        {
            _user = user;
            ChekcPassword();
        } 
        
        private void ChekcPassword()
        {
            while (incorrectPwdEntris < 3)
            {
                Console.Write("Podaj Hasło: ");
                string input = Console.ReadLine();
                if (input == password)
                {
                    MainControll mainControll = new MainControll();

                    Console.WriteLine("------------------");
                    Console.WriteLine("{0}, Witaj w aplikacji!!", _user);                   

                    Console.WriteLine("------comm żeby wyświetlić listę komend------");
                    mainControll.ControllMenu();

                }
                else
                {
                    Console.WriteLine("Złe hasło!!");
                    incorrectPwdEntris++;
                }
            }

            Console.WriteLine("Wciśnij dowolny przycisk by wyjść z aplikacji");
            Console.ReadLine();
        }
    }
}

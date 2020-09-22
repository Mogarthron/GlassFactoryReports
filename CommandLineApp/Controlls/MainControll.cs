using System;
using System.Collections.Generic;
using System.Text;

namespace CommandLineApp.Controlls
{
    public class MainControll : Controll
    {
        public void ControllMenu()
        {
            Console.WriteLine(_title);

            while (true)
            {
                Console.Write(_user);

                string input = Console.ReadLine();                

                switch (CommandPointer(input))
                {
                    case 0:
                        CommentsDTControll commentsControll = new CommentsDTControll();
                        commentsControll.ControllMenu();
                        break;
                    case 1:
                        BatchControll batchControll = new BatchControll();
                        batchControll.ControllMenu();
                        break;
                    case 99:                        
                        Console.WriteLine();
                        break;
                    case 101:
                        break;
                    default:
                        Console.WriteLine("Brak komendy!!");
                        break;
                }

            }
        }

        public MainControll()
        {
            _user = "Menu >> ";

            _title = "------Menu-------";

            _comm = new List<string>()
            {
                "UwagiDT",
                "Zestawiarnia",
                "HR",
                "Dostawy",
                "Raporty",
                "Cofnij",
                "Admin"
            };
        }
    }
}

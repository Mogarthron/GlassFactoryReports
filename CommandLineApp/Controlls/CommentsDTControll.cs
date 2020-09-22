using System;
using System.Collections.Generic;
using System.Text;
using Core3Library.Querys;

namespace CommandLineApp.Controlls
{
    public class CommentsDTControll : Controll
    {
        CommentsDTQuery query = new CommentsDTQuery(); 

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
                        ShowComments();
                        break;
                    case 4:
                        MainControll mainControll = new MainControll();
                        mainControll.ControllMenu();
                        break;
                    case 99:
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Brak komendy!!");
                        break;
                }

            }
        }

        private void ShowComments()
        {
            Console.WriteLine();
            query.ShowAllComments().ForEach(x =>
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Data: {0}| Tytuł: {1}", x.Date, x.Category);
                Console.WriteLine(x.Discription);
                Console.WriteLine("------------------------------");
            });
        }

        public CommentsDTControll()
        {
            _user = ":Podaj Komenede >> ";
            _title = "------Menu UwagiDT-------";

            _comm = new List<string>()
            {
                "Pokaż_wszystkie",
                "Dadaj_komentaż",
                "Edytuj_komentaż",
                "Usuń_komentaż",
                "Wyjdź"
            };
        }
    }
}

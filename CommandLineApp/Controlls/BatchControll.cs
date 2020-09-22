using System;
using System.Collections.Generic;
using System.Text;
using Core3Library.Querys;

namespace CommandLineApp.Controlls
{
    public class BatchControll : Controll
    {
        //To Do
        //Add Date validation in StringToDateConverter()
        //Add Range select 
        //Add Batch summary

        BatchQuery query = new BatchQuery();        

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
                        ShowBatches();
                        break;
                    case 1:
                        Range();
                        break;
                    case 2:
                        InsertBatch();
                        break;
                    case 3:
                        MainControll main = new MainControll();
                        main.ControllMenu();
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
        
        private void ShowBatches()
        {
            query.ShowBatches().ForEach(x =>
            {
                Console.WriteLine("{0}, {1}, {2}",x.Date,x.NameOfRecipe,x.SumOfPreparedBatches);
            });
        }

        private void Range()
        {
            Console.WriteLine("Jeden dzien(1), Zakres(2)");
            string range = Console.ReadLine();

            Console.WriteLine("Format Daty: RRRR.MM.DD");

            if (range == "1")
            {
                Console.Write("Wpisz datę: ");
                string date = Console.ReadLine();

                ShowRange(date, date);
            }
            else if (range == "2")
            {
                Console.Write("Pokaż zakres od: ");
                string from = Console.ReadLine();

                Console.Write("Pokaż zakres do: ");
                string to = Console.ReadLine();

                ShowRange(from, to);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date">date format: YYYY.MM.DD</param>
        /// <returns></returns>
        private DateTime StringToDateConverter(string date)
        {
            int Year = int.Parse(date.Substring(0, 4));
            int Month = int.Parse(date.Substring(5, 2));
            int Day = int.Parse(date.Substring(8, 2));

            DateTime date1 = new DateTime(Year, Month, Day);

            return date1;
        }

        private void ShowRange(string from, string to)
        {
            DateTime date1 = StringToDateConverter(from);
            DateTime date2 = StringToDateConverter(to);

            query.ShowRange(date1, date2).ForEach(x =>
            {
                Console.WriteLine("{0} {1}: {2} szt.", x.Date, x.NameOfRecipe, x.SumOfPreparedBatches);
            });

            //Console.WriteLine(date1.ToString());
            //Console.WriteLine(date2.ToString());
        }

        private void InsertBatch()
        {
            RecipeQuery recipe = new RecipeQuery();

            string[] listOfRecipeNames = new string[10];
            string[] listOfPreparedBaches = new string[10];
            int listIndex = 0;

            Console.WriteLine("----Dodaj Zesatw----");
            Console.Write("Wpisz datę: ");
            string date = Console.ReadLine();

            DateTime date1 = StringToDateConverter(date);

            Console.WriteLine("Dostępne Receptury: ");
            ListOfRecipeNames(recipe);           

            //Loop where you can write how meny batches where prepared             
            while (true)
            {
                Console.Write("Nazwa receptury: ");
                string nameOfRecipe = Console.ReadLine();
                Console.Write("Ile Zestawów: ");
                string howMeny = Console.ReadLine();

                listOfRecipeNames[listIndex] = nameOfRecipe;
                listOfPreparedBaches[listIndex] = howMeny;

                listIndex++;
                string com = Console.ReadLine();
                if (com == "q") break;
                
                if (com == "r") ListOfRecipeNames(recipe);               
            }
              
            //Insert batches to DB
            for(int j = 0; j < listIndex; j++)
            {
                recipe.UserRecipes().ForEach(x =>
                {
                    if (listOfRecipeNames[j] == x.RecipeName) query.InsertBatch(date1, x.GetID(), int.Parse(listOfPreparedBaches[j]));
                });
            }
        }

        private void ListOfRecipeNames(RecipeQuery recipe)
        {             
            int recipeNumber = 1;
            recipe.UserRecipes().ForEach(x =>
            {
                Console.WriteLine("nr {0}: {1}", recipeNumber, x.RecipeName);
                recipeNumber++;
            });
        }

        public BatchControll()
        {
            _user = "Podaj komentę >> ";
            _title = "------Menu Zestawiarnia-------";

            _comm = new List<string>()
            {               
                "Pokaż_wszytkie_zestawy",
                "Pokaż_zakres",
                "Dadaj_zestaw",
                "Wyjdź"
            };           
        }
    }
}

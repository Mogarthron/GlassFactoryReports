using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLogic logic = new BusinessLogic();

            //OpenTXT file = new OpenTXT("TopRap.txt");


            //Console.WriteLine("{0}: {1}",file.meltRepo[0]._dateTime,file.meltRepo[0]._WEBatch);
            //Console.WriteLine(file.meltRepo[5]);
            //Console.WriteLine(file.meltRepo[11]);

            //Console.WriteLine(file.fileContent[0]);
            //Console.WriteLine(file.fileContent[5]);
            //Console.WriteLine(file.fileContent[11]);

            //logic.RecipeComposition();

            //logic.MasPrcComposition();          

            //logic.MeltingReport();

            logic.TableOfGlassLevel(100, 250, 40, 400);

            while (true)
            {
                logic.GlassLevel();
            }
        }        
    }
}

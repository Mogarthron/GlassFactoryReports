using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLogic logic = new BusinessLogic();

            //logic.RecipeComposition();

            //logic.MasPrcComposition();          

            logic.MeltingReport();

            //logic.TableOfGlassLevel(30, 330, 40, 360);

            while (true)
            {
                logic.GlassLevel();
            }
        }        
    }
}

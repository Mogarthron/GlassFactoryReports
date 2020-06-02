using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public class BusinessLogic
    {
        tRecipeComposition recipeComposition = new tRecipeComposition();        

        tGlassLevel glassLevel;
        
        public void MeltingReport()
        {
            float WEBatchWeight = 450f;

            List<int> indexs = new List<int>();            

            List<tMeltRepo> meltRepos = new List<tMeltRepo>()
            {
                new tMeltRepo(new DateTime(2020,5,20,6,1,0),"5.5","5",145,1),
                //new tMeltRepo(new DateTime(2020,5,20,7,1,0),"5.5","5",145,0),
                //new tMeltRepo(new DateTime(2020,5,20,8,1,0),"5.5","5",145,0),
                //new tMeltRepo(new DateTime(2020,5,20,9,1,0),"5.5","5",145,0),
                new tMeltRepo(new DateTime(2020,5,20,10,1,0),"5.5","5",145,1),
                //new tMeltRepo(new DateTime(2020,5,20,11,1,0),"5.5","5",145,0),
                //new tMeltRepo(new DateTime(2020,5,20,12,1,0),"5.5","5",145,0),
                //new tMeltRepo(new DateTime(2020,5,20,13,1,0),"5.5","5",145,0),
                new tMeltRepo(new DateTime(2020,5,20,14,1,0),"5.5","5",145,1),
                //new tMeltRepo(new DateTime(2020,5,20,15,1,0),"5.5","5",145,0),
                //new tMeltRepo(new DateTime(2020,5,20,16,1,0),"5.5","5",145,0),
                //new tMeltRepo(new DateTime(2020,5,20,17,1,0),"5.5","5",145,0),
                new tMeltRepo(new DateTime(2020,5,20,18,1,0),"5.5","5",145,1),
                //new tMeltRepo(new DateTime(2020,5,20,19,1,0),"5.5","5",145,0),
                //new tMeltRepo(new DateTime(2020,5,20,20,1,0),"5.5","5",145,0),
                //new tMeltRepo(new DateTime(2020,5,20,21,1,0),"5.5","5",145,0),
                //new tMeltRepo(new DateTime(2020,5,20,22,1,0),"5.5","5",145,0),
                new tMeltRepo(new DateTime(2020,5,20,23,1,0),"5.5","5",145,1),
                //new tMeltRepo(new DateTime(2020,5,20,00,1,0),"5.5","5",145,0),
                //new tMeltRepo(new DateTime(2020,5,20,1,1,0),"5.5","5",145,0),
                new tMeltRepo(new DateTime(2020,5,20,2,1,0),"5.5","5",145,1),
                //new tMeltRepo(new DateTime(2020,5,20,3,1,0),"5.5","5",145,0),
                //new tMeltRepo(new DateTime(2020,5,20,4,1,0),"5.5","5",145,0),
                //new tMeltRepo(new DateTime(2020,5,20,5,1,0),"5.5","5",145,0),
                new tMeltRepo(new DateTime(2020,5,21,6,1,0),"5.5","5",145,1),
                //new tMeltRepo(new DateTime(2020,5,21,7,1,0),"5.5","5",145,0),
                //new tMeltRepo(new DateTime(2020,5,21,8,1,0),"5.5","5",145,0),
                //new tMeltRepo(new DateTime(2020,5,21,9,1,0),"5.5","5",145,0),
                new tMeltRepo(new DateTime(2020,5,21,10,1,0),"5.5","5",145,1),
                //new tMeltRepo(new DateTime(2020,5,21,11,1,0),"5.5","5",145,0),
                //new tMeltRepo(new DateTime(2020,5,21,12,1,0),"5.5","5",145,0),
                //new tMeltRepo(new DateTime(2020,5,21,13,1,0),"5.5","5",145,0),
                new tMeltRepo(new DateTime(2020,5,21,14,1,0),"5.5","5",145,1),
                //new tMeltRepo(new DateTime(2020,5,21,15,1,0),"5.5","5",145,0),
                //new tMeltRepo(new DateTime(2020,5,21,16,1,0),"5.5","5",145,0),
                //new tMeltRepo(new DateTime(2020,5,21,17,1,0),"5.5","5",145,0),
                new tMeltRepo(new DateTime(2020,5,21,18,1,0),"5.5","5",145,1),
                //new tMeltRepo(new DateTime(2020,5,21,19,1,0),"5.5","5",145,0),
                //new tMeltRepo(new DateTime(2020,5,21,20,1,0),"5.5","5",145,0),
                //new tMeltRepo(new DateTime(2020,5,21,21,1,0),"5.5","5",145,0),
                //new tMeltRepo(new DateTime(2020,5,21,22,1,0),"5.5","5",145,0),
                new tMeltRepo(new DateTime(2020,5,21,23,1,0),"5.5","5",145,1),
                //new tMeltRepo(new DateTime(2020,5,21,00,1,0),"5.5","5",145,0),
                //new tMeltRepo(new DateTime(2020,5,21,1,1,0),"5.5","5",145,0),
                new tMeltRepo(new DateTime(2020,5,21,2,1,0),"5.5","5",145,1),
                //new tMeltRepo(new DateTime(2020,5,21,3,1,0),"5.5","5",145,0),
                //new tMeltRepo(new DateTime(2020,5,21,4,1,0),"5.5","5",145,0),
                //new tMeltRepo(new DateTime(2020,5,21,5,1,0),"5.5","5",145,0)
            };

            List<tMeltRepo> newMeltRepos = new List<tMeltRepo>();

            List<tPullRateTable> pullRateTable = new List<tPullRateTable>();

            //meltRepos.ForEach(x => Console.WriteLine("Czas {0} zasyp: {1}", x._dateTime, x._WEBatch));

            //Faind indexes where batch = 1 and add index value to indexs List
            meltRepos.ForEach(x =>
            {
                if (x._WEBatch == 1)
                    indexs.Add(meltRepos.FindIndex(p => p._dateTime == x._dateTime));
            });

            int c = 0;

            foreach(int i in indexs)
            {                
                if(c == indexs.Count - 1)
                {                    
                    //Console.WriteLine("Koniec pętli");
                    break;
                }
                else
                {
                    DateTime time1 = meltRepos[indexs[c]]._dateTime;
                    DateTime time2 = meltRepos[indexs[c + 1]]._dateTime;

                    float WEpullrate = 0f;

                    int div = time2.Subtract(time1).Hours;

                    if (div < 0)
                    {
                        div = div + 24;
                        WEpullrate = WEBatchWeight / (div);

                        for (int r = 0; r < div; r++)
                        {
                            newMeltRepos.Add(new tMeltRepo(time1.AddHours(r), WEpullrate));
                        }
                    }
                    else
                    {
                        WEpullrate = WEBatchWeight / div;

                        for (int r = 0; r < div; r++)
                        {
                            newMeltRepos.Add(new tMeltRepo(time1.AddHours(r), WEpullrate));
                        }
                    }                                     

                    c++;
                }                
            }

            newMeltRepos.ForEach(x => Console.WriteLine("Data {0:yyyy.MM.dd HH} wydobycie na godzine {1}", x._dateTime, x._PullRate));

            float Shift1 = 0;
            float Shift2 = 0;
            float Shift3 = 0;

            int firstDate = newMeltRepos[0]._dateTime.Day;

            List<DateTime> dates = new List<DateTime>();



            
            

            //tPullRateTable rowOfTable;

            //Console.WriteLine(newMeltRepos.Count);

            //for (int j = 0; j < newMeltRepos.Count; j++)
            //{
            //    if ((firstDate - newMeltRepos[j]._dateTime.Day) == 0)
            //    {
            //        if (newMeltRepos[j]._dateTime.Hour >= 6 & newMeltRepos[j]._dateTime.Hour < 14) Shift1 += newMeltRepos[j]._PullRate;
            //        else if (newMeltRepos[j]._dateTime.Hour >= 14 & newMeltRepos[j]._dateTime.Hour < 22) Shift2 += newMeltRepos[j]._PullRate;
            //        else Shift3 += newMeltRepos[j]._PullRate;
            //    }
            //}

            

            //Console.WriteLine("Zmiana I: {0}", Shift1);
            //Console.WriteLine("Zmiana II: {0}", Shift2);
            //Console.WriteLine("Zmiana III: {0}", Shift3);
            //Console.WriteLine("Całkowity pobór Opalu: {0}", Shift1 + Shift2 + Shift3);

        }

        public void RecipeComposition()
        {
            Console.WriteLine("Receptura Opalin");
            recipeComposition.rawMaterials.ForEach(x => Console.WriteLine("{0} : {1} kg", x.Name, x.Quantity));
            Console.WriteLine("Suma surowców w recepturze: {0}kg", recipeComposition.SumOfMaterials());
        }

        public void MasPrcComposition()
        {
            Console.WriteLine("Skład procentowy surowców w Opalinie");
            recipeComposition.MasComposition().ForEach(x => 
            {
                if (x.Quantity * 100f < 1f) Console.WriteLine("{0} : {1:0.00}%", x.Name, x.Quantity * 100f);
                else Console.WriteLine("{0} : {1:#.00}%", x.Name, x.Quantity * 100f);
            });
        }

        public void GlassLevel()
        {
            int HeightOfMeltingArea = 430;
            int HeightOfProgWyrobowy = 15;
            int WidthOfMeltingArea = 1800;
            int WidthOfFuranceBase = 2850;

            tFurance WWFurance = new tFurance(HeightOfMeltingArea, HeightOfProgWyrobowy, WidthOfMeltingArea, WidthOfFuranceBase);

            string mg;
            string ac;
            string spacja = "-----------------------------------------------";

            Console.WriteLine("Podaj poziom szkła: ");
            mg = Console.ReadLine();
            Console.WriteLine("Podaj wychylenie na siłowniku: ");
            ac = Console.ReadLine();

            glassLevel = new tGlassLevel(WWFurance);           
            
            Console.WriteLine(spacja);
            Console.WriteLine("Poziom szkła po postawiniu na 4 łapy: {0:##0.0}mm", glassLevel.LevelOfGlass(mg,ac));
            Console.WriteLine(spacja);
            Console.WriteLine("Wysokość tafli szkła na przeciwległej ścianie: {0:##0.0}mm", glassLevel.EH());
            Console.WriteLine(spacja);
            Console.WriteLine("Kąt wychylenia podstawy wanny: {0:##0.00000}rad", glassLevel.aABC());            
            Console.WriteLine(spacja);            
        }

        /// <summary>
        /// Table of glass lvl's. Enter only full values i.e.: 300 or 150 not 155 or 304
        /// </summary>
        /// <param name="rowStart">first row Value of mesured glass lvl in mm</param>
        /// <param name="rowStop">last row Value mesured glass lvl in mm</param>
        /// <param name="colStart">first column value of furance base lift in mm</param>
        /// <param name="colStop">lasr column value of furance base lift in mm</param>
        public void TableOfGlassLevel(int rowStart, int rowStop, int colStart, int colStop)
        {
            int HeightOfMeltingArea = 430;
            int HeightOfProgWyrobowy = 15;
            int WidthOfMeltingArea = 1800;
            int WidthOfFuranceBase = 2850;

            tFurance WWFurance = new tFurance(HeightOfMeltingArea, HeightOfProgWyrobowy, WidthOfMeltingArea, WidthOfFuranceBase);
            glassLevel = new tGlassLevel(WWFurance);

            int rowLength = ((rowStop - rowStart) / 10) + 1;
            int colLength = ((colStop - colStart) / 10) + 1;  

            List<string> lines = glassLevel.TableOfGlassLevels(rowStart, rowStop, colStart, colStop);
            string path = "GlassLevels.txt";

            if (System.IO.File.Exists(path) == false)
            {
                Console.WriteLine("Utworzono plik");
                Console.WriteLine("Wiersze: {0}", rowLength);
                Console.WriteLine("Kolumny: {0}", colLength);
            }
            else
            {
                Console.WriteLine("Nadpisano plik!");
            }          

            System.IO.File.AppendAllLines(path, lines.ToArray());
        }
    }
}

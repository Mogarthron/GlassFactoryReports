using System;
using System.Diagnostics;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLogic logic = new BusinessLogic();

            logic.PrintWTComposition(logic);

            Console.ReadLine();

            Console.WriteLine("Chcesz uruhomić RDT??  Y/N");
            string ans = Console.ReadLine();

            if (ans == "Y")
            {
                Console.WriteLine("Apka uruchomina");
                using (Process myProcess = new Process())
                {
                    myProcess.StartInfo.FileName = @"D:\Dev\projekty GitHub\GlassFactoryReports\BachPlantDesktop\bin\Debug\netcoreapp3.1\BachPlantDesktop.exe";
                    myProcess.StartInfo.UseShellExecute = false;
                    myProcess.StartInfo.RedirectStandardInput = true;

                    myProcess.Start();

                    myProcess.WaitForExit();
                }
            }
            else
            {
                Console.WriteLine("Dowidzenia");
            }           
        }        
    }
}

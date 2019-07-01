using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole
{
    public class BusinessLogic
    {
        public List<RawMaterial> SodaLimeGL = new List<RawMaterial>()
        {
            new RawMaterial("Sand", 150),
            new RawMaterial("Soda", 49.5),
            new RawMaterial("Lime", 30),            
        };

        private double ChemicalComposition(BusinessLogic logic)
        {
            List<RawMaterial> Logic = logic.SodaLimeGL;

            double massSum = 0;

            for (int i = 0; i < Logic.Count; i++)
            {
                massSum += Logic[i].PartialMass;
            }

            return massSum;
        }

        public void PrintWTComposition(BusinessLogic log)
        {
            List<RawMaterial> Logic = log.SodaLimeGL;

            for (int i = 0; i < Logic.Count; i++)
            {
                Console.WriteLine($"{Logic[i].Name}: {(Logic[i].PartialMass / ChemicalComposition(log) * 100).ToString("0.00")}%");
            }
        }




    }
}

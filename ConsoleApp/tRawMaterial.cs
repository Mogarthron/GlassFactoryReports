using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class tRawMaterial
    {
        public string Name;
        public float Quantity;
        public List<tOxide> Compound = new List<tOxide>();

        public tRawMaterial(string name, float quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public tRawMaterial(string name, float quantity, List<tOxide> oxides)
        {

        }
        
    }
}

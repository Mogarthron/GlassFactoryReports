using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class tOxide
    {
        public string Name;
        public float MollarMass;
        public float DensityFactor;

        public tOxide(string name, float mMass, float dFactor)
        {
            Name = name;
            MollarMass = mMass;
            DensityFactor = dFactor;
        }
    }
}

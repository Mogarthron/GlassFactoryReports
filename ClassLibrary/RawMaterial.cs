using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class RawMaterial
    {
        private string _name;
        private double _partialMass;
        private double _molarMass;
        private string _description;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }       

        public double PartialMass
        {
            get { return _partialMass; }
            set { _partialMass = value; }
        }

        public double MolarMass
        {
            get { return _molarMass; }
            set { _molarMass = value; }
        }
                     
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        

        #region ctor
        //Console test 
        public RawMaterial(string name, double mass)
        {
            _name = name;
            _partialMass = mass;
        }



        #endregion
    }
}

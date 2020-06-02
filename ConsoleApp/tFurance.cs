using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    /// <summary>
    /// Test class for Furance discription
    /// </summary>
    public class tFurance
    {
        public int HeightOfProgWyrobowy;
        public int WidthOfMeltingArea;
        public int LengthOfMeltingArea;
        public int HeightOfMeltingArea;
        public int WidthOfFuranceBase;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IF">Height of melting area</param>
        /// <param name="NI">Height of prog wyrobowy</param>
        /// <param name="EF">Width of melting area</param>
        /// <param name="BC">Width of furance base</param>
        public tFurance(int IF,int NI, int EF, int BC)
        {            
            HeightOfProgWyrobowy = NI;
            HeightOfMeltingArea = IF;
            WidthOfMeltingArea = EF;
            WidthOfFuranceBase = BC;
        }

    }
}

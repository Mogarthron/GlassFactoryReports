using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class tGlassLevel
    {
        #region Private parameters

        private tFurance _tFurance;

        /// <summary>
        /// Mesured Glass lvl
        /// </summary>
        private double _MG;
     
        /// <summary>
        /// Furance lift
        /// </summary>
        private double _AC;

        /// <summary>
        /// Angle of furance base lift
        /// </summary>
        private double _aABC;

        /// <summary>
        /// _aACB = 90 deg - _aABC
        /// </summary>
        private double _aACB;

        /// <summary>
        /// _aHGL = _aABC
        /// </summary>
        private double _aHGL;

        /// <summary>
        /// Lenght of glass surface after lift
        /// </summary>
        private double _HG;
        private double _FG;
        private double _HL;
        private double _EH;
        private double _AreaOfEFGH;
        private double _FGAlfa0;

        #endregion
       
        #region Public metods

        public double aABC()
        {
            return _aABC;
        }       

        public double aACB()
        {
            return _aACB;
        }        

        public double aHGL()
        {
            return _aHGL;
        }
        
        /// <summary>
        /// Mesured glass lvl
        /// </summary>
        public double MG()
        {
            return _MG;
        }   
               
        /// <summary>
        /// Lift lvl
        /// </summary>
        public double AC()
        {
            return _AC;
        }        

        public double HG()
        {
            return _HG;
        }       

        public double FG()
        {
            return _FG;
        }        

        public double HL()
        {
            return _HL;
        }        

        /// <summary>
        /// Height of glass surface from bottom of furance on opisite side of furance
        /// </summary>
        /// <returns></returns>
        public double EH()
        {
            return _EH;
        }        

        public double AreaOfEFGH()
        {
            return _AreaOfEFGH;
        }

        #endregion

        private double Calc()
        {
            _aABC = _AC / _tFurance.WidthOfFuranceBase;
            _aACB = Math.PI / 2 - _aABC;
            _aHGL = Math.PI / 2 - _aACB;


            _HG = _tFurance.WidthOfMeltingArea / Math.Cos(_aHGL);
            _HL = Math.Tan(_aHGL) * _tFurance.WidthOfMeltingArea;
            _FG = _tFurance.HeightOfMeltingArea + _tFurance.HeightOfProgWyrobowy - (_MG / Math.Sin(_aACB));
            _EH = _FG - _HL;

            _AreaOfEFGH = (_EH + _FG) * _tFurance.WidthOfMeltingArea * 0.5;

            _FGAlfa0 = _AreaOfEFGH / _tFurance.WidthOfMeltingArea;

            if (_FGAlfa0 < 0) return 0f;
            else return _FGAlfa0;
        }

        public double LevelOfGlass(string mg, string ac)
        {
            _AC = double.Parse(ac);
            _MG = double.Parse(mg);

            return Calc();
        }

        public double LevelOfGlass(int mg, int ac)
        {
            _AC = (double)ac;
            _MG = (double)mg;

            return Calc();
        }


        /// <summary>
        /// Table of glass lvl's. Enter only full values i.e.: 300 or 150 not 155 or 304
        /// </summary>
        /// <param name="rowStart">first row Value of mesured glass lvl in mm</param>
        /// <param name="rowStop">last row Value mesured glass lvl in mm</param>
        /// <param name="colStart">first column value of furance base lift in mm</param>
        /// <param name="colStop">lasr column value of furance base lift in mm</param>
        public List<string> TableOfGlassLevels(int rowStart, int rowStop, int colStart, int colStop)
        {
            int rowLength = ((rowStop - rowStart) / 10) + 1;
            int colLength = ((colStop - colStart) / 10) + 1;

            int[] row = new int[rowLength];
            int[] col = new int[colLength];

            List<string> lines = new List<string>();

            string header = "MG|AC  ";

            for (int i = 0; i < rowLength; i++)
            {
                row[i] = (rowStart + i * 10);               
            }

            for (int i = 0; i < colLength; i++)
            {
                col[i] = (colStart + i * 10);
                header += col[i] + " ";
            }

            lines.Add(header);

            for (int r = 0; r < row.Length; r++)
            {
                string srow = row[r].ToString() + " ";
                
                for (int c = 0; c < col.Length; c++)
                {
                    srow += LevelOfGlass(row[r], col[c]) + " ";
                }

                lines.Add(srow);
            }

            return lines;
        }


        #region ctor

        public tGlassLevel(tFurance tFurance)
        {
            _tFurance = tFurance;
        }

        public tGlassLevel()
        {

        }

        #endregion
    }
}

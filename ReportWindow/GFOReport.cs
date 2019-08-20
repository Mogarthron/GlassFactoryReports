using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportWindow
{
    /// <summary>
    /// Glass furance operator report
    /// </summary>
    public class GFOReport
    {
        private int Id { get; set; }
        public DateTime dateTime { get; set; }

        public float ElectricFuranceTimeFeed { get; set; }
        public float ElectricFuranceGlassLevel { get; set; }
        public float Power { get; set; }
        public float ElectricFuranceBatchPortion { get; set; }

        public float GasFuranceTimeFeed { get; set; }
        public float GasFuranceGlassLevel { get; set; }
        public float Gas { get; set; }
        public float GasFuranceBatchPortion { get; set; }


        public GFOReport(string EFTF)
        {
            dateTime = DateTime.Now;
            ElectricFuranceTimeFeed = float.Parse(EFTF);
        }

    }
}

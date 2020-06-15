using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Globalization;

namespace ConsoleApp
{
    public class OpenTXT
    {
        public List<string> fileContent = new List<string>();
        public List<tMeltRepo> meltRepo = new List<tMeltRepo>();

        public string Text ;


        public OpenTXT(string path)
        {
            char sep = '\t';
            char sep2 = '|';
            string[] row;

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(path).ToList();

            foreach(string line in lines)
            {
                row = line.Split(sep);
                string newRow = "";
                string _dateTime = row[0] + " " + row[1];
                string WEFeed = row[2];
                string WELevel = row[3];
                string WEPower = row[4].Replace(',','.');
                string WEBatch = row[5];
               // newRow = _dateTime + sep2 + WEFeed + sep2 + WELevel + sep2 + WEPower + sep2 + WEBatch;
                //fileContent.Add(newRow);

                int year = int.Parse(row[0].Substring(6, 4));
                int month = int.Parse(row[0].Substring(3, 2));
                int day = int.Parse(row[0].Substring(0, 2));
                int hour = int.Parse(row[1]);

                DateTime dateTime = new DateTime(year, month, day, hour, 0, 0);
                int zero;
                int webatch;

                CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
                ci.NumberFormat.CurrencyDecimalSeparator = ".";
                //avarage = double.Parse("0.0", NumberStyles.Any, ci);
                float power;
                power = float.Parse(WEPower, NumberStyles.Any, ci);
                if (String.IsNullOrEmpty(row[5]))
                {
                    webatch = 0;
                }
                else
                {
                    webatch = int.Parse(row[5]);
                }
                meltRepo.Add(new tMeltRepo(dateTime, WEFeed, WELevel, power, webatch));
            }        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class tMeltRepo
    {
        public DateTime _dateTime;
        string _WEFeed;
        string _WELevel;
        int _WEPower;
        public int _WEBatch;
        public float _PullRate;

        public tMeltRepo(DateTime dateTime, string wefeed, string welevel, int power, int webatch)
        {
            _dateTime = dateTime;
            _WEFeed = wefeed;
            _WELevel = welevel;
            _WEPower = power;
            _WEBatch = webatch;
        }

        public tMeltRepo(DateTime dateTime, float pullRate)
        {
            _dateTime = dateTime;
            _PullRate = pullRate;
        }
        public tMeltRepo()
        {

        }
    }
}

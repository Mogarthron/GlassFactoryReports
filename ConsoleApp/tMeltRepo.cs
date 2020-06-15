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
        float _WEPower;
        public int _WEBatch;
        public float _WEPullRate;
        string _WGFeed;
        string _WGLevel;
        int _WGFlowOfGase;
        public int _WGBatch;

        public tMeltRepo(DateTime dateTime, string wefeed, string welevel, float power, int webatch)
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
            _WEPullRate = pullRate;
        }
        public tMeltRepo()
        {

        }
    }
}

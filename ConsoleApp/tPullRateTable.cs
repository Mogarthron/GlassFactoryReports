using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class tPullRateTable
    {
        DateTime _date;
        float _Shift1;
        float _Shift2;
        float _Shift3;
        
        public DateTime date
        {
            get { return _date; }
            set { _date = value; }
        }

        public float Shift1
        {
            get { return _Shift1; }
            private set { _Shift1 = value; }
        }

        public float Shift2
        {
            get { return _Shift2; }
            private set { _Shift2 = value; }
        }

        public float Shift3
        {
            get { return _Shift3; }
            private set { _Shift3 = value; }
        }

        

        public void SetWE1(float s)
        {
            _Shift1 += s;
        }

        public void SetWE2(float s)
        {
            _Shift2 += s;
        }

        public void SetWE3(float s)
        {
            _Shift3 += s;
        }


        public tPullRateTable(DateTime date)
        {
            _date = date;
            _Shift1 = 0;
            _Shift2 = 0;
            _Shift3 = 0;
        }


        public tPullRateTable(DateTime date, float s1, float s2, float s3)
        {
            _date = date;
            _Shift1 = s1;
            _Shift2 = s2;
            _Shift3 = s3;
        }
    }
}

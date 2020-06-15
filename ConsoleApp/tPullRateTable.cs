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
        private float _WE1;
        private float _WE2;
        private float _WE3;

        public float WE1
        {
            get { return _WE1; }
            set { _WE1 = value; }
        }       

        public float WE2
        {
            get { return _WE2; }
            set { _WE2 = value; }
        }        

        public float WE3
        {
            get { return _WE3; }
            set { _WE3 = value; }
        }

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
            _WE1 += s;
        }

        public void SetWE2(float s)
        {
            _WE2 += s;
        }

        public void SetWE3(float s)
        {
            _WE3 += s;
        }

        public float OpalPullRate()
        {
            return _WE1 + _WE2 + _WE3;
        }

        public tPullRateTable(DateTime date)
        {
            _date = date;
            _WE1 = 0;
            _WE2 = 0;
            _WE3 = 0;
        }


        public tPullRateTable(DateTime date, float s1, float s2, float s3)
        {
            _date = date;
            _WE1 = s1;
            _WE2 = s2;
            _WE3 = s3;
        }
    }
}

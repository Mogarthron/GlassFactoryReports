using System;
using System.Collections.Generic;
using System.Text;


namespace CommandLineApp.Controlls
{
    public class Controll
    {

        //To DO
        //Add here ControllMenu and chage swich case to List of something

        protected string _title;

        protected string _user;

        protected List<string> _comm;

        public void SetUser(string user)
        {
            _user = user;
        }

        protected int CommandPointer(string input)
        {
            if (input == "cls")
            {
                Console.Clear();
                return 101;
            }

            if (input == "comm")
            {
                _comm.ForEach(x =>
                {
                    Console.WriteLine(x);
                });
                return 99;                
            }

            for (int i = 0; i < _comm.Count; i++)
            {
                if (input == _comm[i])
                {
                    return i;
                }
            }

            return 100;
        }
    }
}

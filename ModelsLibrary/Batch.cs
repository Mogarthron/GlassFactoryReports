using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary
{
    /// <summary>
    /// klasa zestawy do wprowadzania zestawów =]
    /// </summary>
    public class Batch : IDClass
    {
        private DateTime _PreparationDate;
        private string _Date;
        private int _id_Recipe;
        private string _NameOfRecipe;
        private int _SumOfPreparedBatches;

        public string Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        public string NameOfRecipe
        {
            get { return _NameOfRecipe; }
            set { _NameOfRecipe = value; }
        }

        public int SumOfPreparedBatches
        {
            get { return _SumOfPreparedBatches; }
            set { _SumOfPreparedBatches = value; }
        }        

        public Batch(int id, DateTime date, string recipeName, int sum)
        {
            SetID(id);
            _PreparationDate = date;
            _Date = date.ToShortDateString();
            _NameOfRecipe = recipeName;
            _SumOfPreparedBatches = sum;
        }  
        
        public Batch(DateTime date, string recipeName, int sum)
        {
            _PreparationDate = date;
            _Date = date.ToShortDateString();
            _NameOfRecipe = recipeName;
            _SumOfPreparedBatches = sum;
        }

        public Batch()
        {

        }
    }
}

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
        private int _id_Recipe;
        private string _nameOfRecipe;
        private int _sumOfPreparedBatches;



        public Batch(int id, DateTime date, int idRecipe, int sum)
        {
            SetID(id);
            _PreparationDate = date;
            _id_Recipe = idRecipe;
            _sumOfPreparedBatches = sum;
        }

        public Batch(int id, DateTime date, string recipeName, int sum)
        {
            SetID(id);
            _PreparationDate = date;
            _nameOfRecipe = recipeName;
            _sumOfPreparedBatches = sum;
        }
    }
}

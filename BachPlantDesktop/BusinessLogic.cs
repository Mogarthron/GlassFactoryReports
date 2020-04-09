using System;
using System.Collections.Generic;
using System.Text;
using Core3Library;
using ModelsLibrary;

namespace BachPlantDesktop
{
    class BusinessLogic
    {
        DBConnection dB = new DBConnection();
        List<Recipe> recipes = new List<Recipe>();

        public List<Recipe> ShowRecipes()
        {
            dB.StartConnection("exec dbo.spReceptury_PokazWszystkie");

            while (dB.dataReader.Read())
            {
                recipes.Add(new Recipe(dB.dataReader.GetInt32(0), dB.dataReader.GetDateTime(1), dB.dataReader.GetString(2), dB.dataReader.GetBoolean(3), dB.dataReader.GetString(4)));
            }

            dB.EndConnection();

            return recipes;
        }

        public BusinessLogic()
        {
            

        }

    }
}

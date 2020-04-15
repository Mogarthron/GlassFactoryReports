using ModelsLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core3Library.Querys
{
    public class RecipeQuery
    {
        DBConnection dB = new DBConnection();
        List<Recipe> recipes = new List<Recipe>();

        public List<Recipe> AdminRecipes()
        {
            dB.StartConnection("exec dbo.spReceptury_PokazWszystkie");

            while (dB.dataReader.Read())
            {
                recipes.Add(new Recipe(dB.dataReader.GetInt32(0), dB.dataReader.GetDateTime(1), dB.dataReader.GetString(2), dB.dataReader.GetBoolean(3), dB.dataReader.GetString(4)));
            }

            dB.EndConnection();

            return recipes;
        }

        public void InsertRecipe(DateTime _date, string _name, string _comments)
        {
            string sp = "dbo.spReceptury_DodajRecepture";            

            dB.AddParameterToList("@DataDodania", System.Data.SqlDbType.Date, _date.ToShortDateString());
            dB.AddParameterToList("@NazwaReceptury", System.Data.SqlDbType.NVarChar, _name);
            dB.AddParameterToList("@Uwagi", System.Data.SqlDbType.NVarChar, _comments);

            dB.InsertConnection(sp);
            
            recipes.Clear();
        }

        public RecipeQuery()
        { 

        }


    }
}

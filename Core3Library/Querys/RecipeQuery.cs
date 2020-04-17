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

        List<string> sp = new List<string>()
        {
            "dbo.spReceptury_DodajRecepture", //Add Recipe to main List
            "dbo.spReceptury_AktualizujDodstepnosc", //Update Active column
            "dbo.spReceptury_WybierzAktywne", //Show active recipes
            "dbo.spReceptury_PokazWszystkie" //Show all recipes
        };


        public List<Recipe> AdminRecipes()
        {
            recipes.Clear();

            dB.StartConnection(sp[3]);

            while (dB.dataReader.Read())
            {
                recipes.Add(new Recipe(dB.dataReader.GetInt32(0), dB.dataReader.GetDateTime(1), dB.dataReader.GetString(2), dB.dataReader.GetBoolean(3), dB.dataReader.GetString(4)));
            }

            dB.EndConnection();

            return recipes;
        }

        public List<Recipe> UserRecipes()
        {
            recipes.Clear();

            dB.StartConnection(sp[2]);

            while (dB.dataReader.Read())
            {
                recipes.Add(new Recipe(dB.dataReader.GetInt32(0), dB.dataReader.GetDateTime(1), dB.dataReader.GetString(2), dB.dataReader.GetBoolean(3), dB.dataReader.GetString(4)));
            }            

            dB.EndConnection();

            return recipes;
        }

        public void InsertRecipe(DateTime _date, string _name, string _comments)
        {
            dB.AddParameterToList("@DataDodania", System.Data.SqlDbType.Date, _date.ToShortDateString());
            dB.AddParameterToList("@NazwaReceptury", System.Data.SqlDbType.NVarChar, _name);
            dB.AddParameterToList("@Uwagi", System.Data.SqlDbType.NVarChar, _comments);

            dB.Connection(sp[0]);

            recipes.Clear();
        }

        public void UpdateRecipeActivity(int id, int a)
        {
            dB.AddParameterToList("@id", System.Data.SqlDbType.Int, id);
            dB.AddParameterToList("@Aktywna", System.Data.SqlDbType.Bit, a);

            dB.Connection(sp[1]);

            recipes.Clear();
        }

        public RecipeQuery()
        { 

        }


    }
}

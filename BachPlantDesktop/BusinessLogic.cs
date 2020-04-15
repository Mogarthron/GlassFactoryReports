using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using BachPlantDesktop.Tables;
using Core3Library.Querys;

namespace BachPlantDesktop
{
    class BusinessLogic
    {
        RecipeTable table = new RecipeTable();
        
        RecipeQuery recipeQuery = new RecipeQuery();
        
        public void LoadRecipes(DataGrid dataGrid)
        {
            //dataGrid.DataContext = table;
            
            dataGrid.ItemsSource = recipeQuery.AdminRecipes();
        }

        public void InsertRecipe(DateTime date, string name, string comm)
        {
            recipeQuery.InsertRecipe(date, name, comm);
        }
        

        public BusinessLogic()
        {
            

        }

    }
}

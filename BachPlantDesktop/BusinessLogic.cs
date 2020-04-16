using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using BachPlantDesktop.Tables;
using Core3Library.Querys;
using ModelsLibrary;

namespace BachPlantDesktop
{
    class BusinessLogic
    {
        #region Recipes

        RecipeQuery recipeQuery = new RecipeQuery();        
        
        public void LoadRecipes(DataGrid dataGrid)
        {            
            dataGrid.ItemsSource = recipeQuery.AdminRecipes();            
        }

        public void InsertRecipe(DateTime date, string name, string comm)
        {
            recipeQuery.InsertRecipe(date, name, comm);
        }

        public void UpdateRecipe(DataGrid dataGrid)
        {
            Recipe recipe = (Recipe)dataGrid.SelectedItem;

            int t = 1;
            int f = 0;
            
            if(recipe.Active == true)
            {
                //MessageBox.Show($"ID {recipe.GetID()}, Active {t}");
                recipeQuery.UpdateRecipeActivity(recipe.GetID(), t);
            }
            else
            {
                //MessageBox.Show($"ID {recipe.GetID()}, Active {f}");
                recipeQuery.UpdateRecipeActivity(recipe.GetID(), f);
            }            
        }

        #endregion


        public BusinessLogic()
        {            

        }
    }
}

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
        RecipeQuery recipeQuery = new RecipeQuery();
        BatchQuery batchQuery = new BatchQuery();        

        #region Recipes

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
                recipeQuery.UpdateRecipeActivity(recipe.GetID(), t);
            }
            else
            {                
                recipeQuery.UpdateRecipeActivity(recipe.GetID(), f);
            }            
        }

        #endregion

        #region Batches

        public void LoadBatches(DataGrid dataGrid)
        {
            dataGrid.ItemsSource = batchQuery.ShowBatches();
        }


        public void LoadRecipesNames(ComboBox comboBox)
        {
            List<string> recipeNames = new List<string>();

            foreach(Recipe r in recipeQuery.UserRecipes())
            {
                recipeNames.Add(r.RecipeName);
            }

            comboBox.ItemsSource = recipeNames;
        }

        public void InsertBatch(DateTime date, string recipeName, int preparatedBatches)
        {            
            foreach(Recipe r in recipeQuery.UserRecipes())
            {
                if (recipeName == r.RecipeName)
                { 
                    //MessageBox.Show(r.GetID().ToString());
                    batchQuery.InsertBatch(date, r.GetID(), preparatedBatches);
                }
            }            
        }



        #endregion

        public BusinessLogic()
        {            

        }
    }
}

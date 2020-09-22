using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using BachPlantDesktop.Tables;
using Core3Library.Querys;


namespace BachPlantDesktop
{
    class BusinessLogic
    {
        RecipeQuery recipeQuery = new RecipeQuery();
        BatchQuery batchQuery = new BatchQuery();
        MaterialQuery materialQuery = new MaterialQuery();

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
            ModelsLibrary.Recipe recipe = (ModelsLibrary.Recipe)dataGrid.SelectedItem;

            if(recipe.Active == true)
            {                
                recipeQuery.UpdateRecipeActivity(recipe.GetID(), 1);
            }
            else
            {                
                recipeQuery.UpdateRecipeActivity(recipe.GetID(), 0);
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
                        
            recipeQuery.UserRecipes().ForEach(x => recipeNames.Add(x.RecipeName));

            comboBox.ItemsSource = recipeNames;
        }

        public void InsertBatch(DateTime date, string recipeName, int preparatedBatches)
        {
            recipeQuery.UserRecipes().ForEach(x =>
            {
                if(recipeName == x.RecipeName)
                {
                    batchQuery.InsertBatch(date, x.GetID(), preparatedBatches);
                }
            });
        }

        #endregion

        #region Materials

        public void LoadMaterials(DataGrid dataGrid)
        {
            dataGrid.ItemsSource = materialQuery.ShowMaterials();
        }

        public void InsertMaterial(string name, string code, string comments)
        {
            materialQuery.InsertMaterial(name, code, comments);
        }

        #endregion

        #region Buttons



        #endregion



        public BusinessLogic()
        {            

        }
    }
}

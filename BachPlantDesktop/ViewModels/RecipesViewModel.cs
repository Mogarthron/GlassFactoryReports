using System;
using System.Collections.Generic;
using System.Text;
using Core3Library.Querys;

namespace BachPlantDesktop.ViewModels
{
    public class RecipesViewModel
    {
        RecipeQuery recipeQuery = new RecipeQuery();

        public void LoadRecipes(System.Windows.Controls.DataGrid dataGrid)
        {
            dataGrid.ItemsSource = recipeQuery.AdminRecipes();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BachPlantDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] LanguageVer = { "Polski", "Englisch" };
        string[] AppTitle = { "Zestawiarnia", "Bach Plant" };
        string[] RecipesTabControllItem = { "Receptury", "Recipes" };
        string[] BachesTabControllItem = { "Zestawy", "Baches" };

        public MainWindow()
        {
            InitializeComponent();
            Title = AppTitle[0];
            TCIRecipes.Header = RecipesTabControllItem[0];
            TCIBaches.Header = BachesTabControllItem[0];
            BtnAddRecipe.Content = "Dodaj Recepturę";
            MLEnglisch.Header = LanguageVer[1];
            MLPolisch.Header = LanguageVer[0];
        }

        private void MLPolisch_Click(object sender, RoutedEventArgs e)
        {
            Title = AppTitle[0];
            TCIRecipes.Header = RecipesTabControllItem[0];
            TCIBaches.Header = BachesTabControllItem[0];
            BtnAddRecipe.Content = "Dodaj Recepturę";          
        }

        private void MLEnglisch_Click(object sender, RoutedEventArgs e)
        {
            Title = AppTitle[1];
            TCIRecipes.Header = RecipesTabControllItem[1];
            TCIBaches.Header = BachesTabControllItem[1];
            BtnAddRecipe.Content = "Add Recipe";
        }
    }
}

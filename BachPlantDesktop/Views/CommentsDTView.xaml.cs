using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BachPlantDesktop.ViewModels;

namespace BachPlantDesktop.Views
{
    /// <summary>
    /// Interaction logic for CommentsDTView.xaml
    /// </summary>
    public partial class CommentsDTView : UserControl
    {
        CommentsDTViewModel viewModel = new CommentsDTViewModel();
        public CommentsDTView()
        {
            InitializeComponent();
            viewModel.ShowComments(CommentsDTDataGrid);
        }

        private void AddCommentBtn_Click(object sender, RoutedEventArgs e)
        {
            MennageCommentView view = new MennageCommentView();
                                  
            PopUpControll pop = new PopUpControll("Utwórz Komentarz", 800, 500, view);

            pop.PopUpShow();

            //PopUpWindow popUp = new PopUpWindow();
            //popUp.Title = "Utworz Komentarz";
            //popUp.Width = 800;
            //popUp.Height = 400;
            //popUp.DataContext = new MennageCommentView();
            //popUp.Show();
        }
    }
}

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
    /// Interaction logic for MennageCommentView.xaml
    /// </summary>
    public partial class MennageCommentView : UserControl
    {
        //CommentsDTViewModel model = new CommentsDTViewModel();
        MennageCommentViewModel model = new MennageCommentViewModel();
        
        public MennageCommentView()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {            
            model.query.AddComment(DateDP.SelectedDate.Value, TitleTB.Text, DiscriptionTB.Text);            
        }
    }
}

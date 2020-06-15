using System;
using System.Collections.Generic;
using System.Text;
using ModelsLibrary;
using Core3Library.Querys;
using System.Windows.Controls;

namespace BachPlantDesktop.ViewModels
{
    public class CommentsDTViewModel
    {
        CommentsDTQuery query = new CommentsDTQuery();

        public void ShowComments(DataGrid dataGrid)
        {
            dataGrid.ItemsSource = query.ShowAllComments();
        }
    }
}

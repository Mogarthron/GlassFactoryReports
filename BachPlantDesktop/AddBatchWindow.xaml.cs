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
using System.Windows.Shapes;

namespace BachPlantDesktop
{
    /// <summary>
    /// Interaction logic for AddBatchWindow.xaml
    /// </summary>
    public partial class AddBatchWindow : Window
    {
        BusinessLogic logic = new BusinessLogic();
        public AddBatchWindow()
        {
            InitializeComponent();
            logic.LoadRecipesNames(CBRecpieName);
        }

        private void BtnAddBatch_Click(object sender, RoutedEventArgs e)
        {
            logic.InsertBatch(DTPreparationDate.SelectedDate.Value, CBRecpieName.Text, int.Parse(TBPreparedBatches.Text));

            this.Close();
        }
    }
}

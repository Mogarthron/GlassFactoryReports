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
using PullRateReport.ViewModels;

namespace PullRateReport.Views
{
    /// <summary>
    /// Interaction logic for PullRateTableView.xaml
    /// </summary>
    public partial class PullRateTableView : UserControl
    {
        PullRateTableViewModel viewModel = new PullRateTableViewModel();

        public PullRateTableView()
        {
            InitializeComponent();
            PullRateDG.ItemsSource = viewModel.pullRates;
        }


    }
}

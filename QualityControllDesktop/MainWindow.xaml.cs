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
using System.IO;
using QualityControllDesktop.ViewModels;


namespace QualityControllDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {            
            InitializeComponent();
        }

        private void ReportTxt(string orderId, string QuEmpId, int defectId)
        {
            string filePath = @".\Raporty\" + orderId + ".csv";
            DateTime date = DateTime.Now;           

            string entry = date.ToString("yyyy.MM.dd HH:mm:ss") + ',' + QuEmpId + ',' + defectId;

            string[] row = { entry };

            File.AppendAllLines(filePath, row.ToList());
        }        

        private void btn_Dobre_Click(object sender, RoutedEventArgs e)
        {          
            ReportTxt(TBAsortyment.Text, TBSortujacy.Text, 1);
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            ReportTxt(TBAsortyment.Text, TBSortujacy.Text, 2);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            ReportTxt(TBAsortyment.Text, TBSortujacy.Text, 3);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            ReportTxt(TBAsortyment.Text, TBSortujacy.Text, 4);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            ReportTxt(TBAsortyment.Text, TBSortujacy.Text, 5);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            ReportTxt(TBAsortyment.Text, TBSortujacy.Text, 6);
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            ReportTxt(TBAsortyment.Text, TBSortujacy.Text, 7);
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            ReportTxt(TBAsortyment.Text, TBSortujacy.Text, 8);
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            ReportTxt(TBAsortyment.Text, TBSortujacy.Text, 9);
        }
    }
}

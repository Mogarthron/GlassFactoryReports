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
        BusinessLogic logic = new BusinessLogic();

        public MainWindow()
        {            
            InitializeComponent();            
        }

        List<string> DefNames = new List<string>() 
        {
            "Dobre",
            "P. pojedynczy",
            "Skupisko pecherzy",
            "Smuga bezbarwna"
        };

        private void ReportTxt(string orderId, string QuEmpId, string defectId)
        {
            string filePath = @".\Raporty\" + orderId + ".csv";
            DateTime date = DateTime.Now;           

            string entry = date.ToString("yyyy.MM.dd HH:mm:ss") + ',' + QuEmpId + ',' + defectId;

            string[] row = { entry };

            File.AppendAllLines(filePath, row.ToList());
        }        

        private void btn_Dobre_Click(object sender, RoutedEventArgs e)
        {          
            ReportTxt(TBAsortyment.Text, TBSortujacy.Text, DefNames[0]);
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            ReportTxt(TBAsortyment.Text, TBSortujacy.Text, DefNames[1]);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            ReportTxt(TBAsortyment.Text, TBSortujacy.Text, DefNames[2]);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            ReportTxt(TBAsortyment.Text, TBSortujacy.Text, DefNames[3]);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            ReportTxt(TBAsortyment.Text, TBSortujacy.Text, "Smuga Barwna");
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            ReportTxt(TBAsortyment.Text, TBSortujacy.Text, "Kamien");
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            ReportTxt(TBAsortyment.Text, TBSortujacy.Text, "Krete");
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            ReportTxt(TBAsortyment.Text, TBSortujacy.Text, "Meszka");
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            ReportTxt(TBAsortyment.Text, TBSortujacy.Text, "Wtracenia Ceramiczne");
        }


    }
}

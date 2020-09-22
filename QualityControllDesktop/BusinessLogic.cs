using QualityControllDesktop.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace QualityControllDesktop
{
    public class BusinessLogic
    {
        public void AddBtn(WrapPanel wrapPanel)
        {
            List<string> LayersOfText = new List<string>()
            {
                "trzecia",
                "czwarta"
            };

            List<QualityButtonViewModel> qualityButtons = new List<QualityButtonViewModel>()
            {
                new QualityButtonViewModel("btn110", 50, 80, LayersOfText),
                new QualityButtonViewModel("btn120", 50, 80, LayersOfText)
            };

            wrapPanel.Children.Add(qualityButtons[0].SetButton());
            wrapPanel.Children.Add(qualityButtons[1].SetButton());
        }

        public void Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReportTxt(string orderId, string QuEmpId, int defectId)
        {
            string filePath = @".\Raporty\" + orderId + ".csv";
            DateTime date = DateTime.Now;

            string entry = date.ToString("yyyy.MM.dd HH:mm:ss") + ',' + QuEmpId + ',' + defectId;

            string[] row = { entry };

            File.AppendAllLines(filePath, row.ToList());
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using QualityControllDesktop.Views;

namespace QualityControllDesktop.ViewModels
{
    public class QualityButtonViewModel
    {
        private int _Heigh;        

        private int _Width;

        public string _Name;

        private RoutedEventHandler _EventHandler;
        
        private List<string> _LayersOfText;                

        public QualityButtonView SetButton()
        {
            QualityButtonView button = new QualityButtonView();                   

            button.Name = _Name;

            button.Height = _Heigh;
            button.Width = _Width;            

            _LayersOfText.ForEach(x =>
            {
                TextBlock tb = new TextBlock();
                tb.TextAlignment = System.Windows.TextAlignment.Center;
                tb.Text = x;
                button.SPLabels.Children.Add(tb);
            });

            //Button btn = new Button();

            //string btnName = "btn_" + _Name;
            //btn.Name = btnName;

            //btn.Click += new RoutedEventHandler(_EventHandler); 

            button.BtnBody.Click += new RoutedEventHandler(btnClicked);
            
            return button;
        }

        private void btnClicked(object sender, RoutedEventArgs e)
        {
            string filePath = @".\Raporty\" + "000000_0000" + ".csv";
            DateTime date = DateTime.Now;

            string entry = date.ToString("yyyy.MM.dd HH:mm:ss") + ',' + "xxxx" + ',' + "222222";

            string[] row = { entry };

            File.AppendAllLines(filePath, row.ToList());
        }

        public QualityButtonViewModel(string name, int height, int width, List<string> layersOfText)
        {
            _Name = name;
            _Heigh = height;
            _Width = width;
            _LayersOfText = layersOfText;
        }
    }
}

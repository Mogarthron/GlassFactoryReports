using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using QualityControllDesktop.Views;
using QualityControllDesktop.Models;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;

namespace QualityControllDesktop.ViewModels
{
    public class QualityButtonViewModel : INotifyPropertyChanged
    {
        QualityButtonModel _buttonModel;

        string kartaFormowania;
        string sortujacy;

        public string TBAsortyment
        {
            get { return kartaFormowania; }
            set
            {
                kartaFormowania = value;
                OnPropertyChaged(nameof(TBAsortyment));
            }
        }

        //public string TBSortujacy 
        //{ 
        //    get { return sortujacy; }
        //    set
        //    {
        //        sortujacy = value;
        //        OnPropertyChaged(nameof(TBSortujacy));
        //    }
        //}

        private ICommand czyTBAsortymentSieZmienilo;
        //private ICommand tbSortujacy;

        public ICommand CzyTBAsortymentSieZmienilo
        {
            get 
            { 
                if (czyTBAsortymentSieZmienilo == null) return new RelayCommand(
                    (object o) => 
                    {
                        OnPropertyChaged(TBAsortyment);
                    });
                return czyTBAsortymentSieZmienilo;
            }
        }

        public QualityButtonView SetButton()
        {            
            QualityButtonView button = new QualityButtonView();
          
            button.Name = _buttonModel.Name;            
            button.Height = _buttonModel.Height;                
            button.Width = _buttonModel.Width;
          
            _buttonModel.LayersOfText.ForEach(x =>
            {
                TextBlock tb = new TextBlock();
                tb.TextAlignment = System.Windows.TextAlignment.Center;
                tb.Text = x;
                button.SPLabels.Children.Add(tb);

            });

            button.BtnBody.Margin = new Thickness(1, 1, 1, 1);

            button.BtnBody.Click += new RoutedEventHandler(btnClicked);              

            return button;
        }

        private void btnClicked(object sender, RoutedEventArgs e)
        {
            string filePath = @".\Raporty\" + "test"+ CzyTBAsortymentSieZmienilo + ".csv";
            DateTime date = DateTime.Now;

            string entry = date.ToString("yyyy.MM.dd HH:mm:ss") + ',' + "Pani_Sor12" + ',' + _buttonModel.id_Defect;

            string[] row = { entry };

            File.AppendAllLines(filePath, row.ToList());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChaged(string propName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public QualityButtonViewModel()
        {

        }
        
        public QualityButtonViewModel(QualityButtonModel model)
        {
            _buttonModel = model;
        }       
    }
}

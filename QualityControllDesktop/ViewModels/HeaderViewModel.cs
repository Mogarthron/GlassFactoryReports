using System;
using System.Collections.Generic;
using System.Text;
using QualityControllDesktop.Models;
using QualityControllDesktop.Views;

namespace QualityControllDesktop.ViewModels
{
    public class HeaderViewModel
    {
        private HeaderModel _headerModel;
        
        public HeaderView SetHeader()
        {
            HeaderView headerView = new HeaderView();

            headerView.LStanowisko.Content = _headerModel.Stanowisko.ToString();
            headerView.CBAsortyment.ItemsSource = _headerModel.Asortyment;
            headerView.CBSortujacy.ItemsSource = _headerModel.Sortujacy;
            headerView.LogOutTimmer.Content = _headerModel.CzasDoWylogowania;

            return headerView;
        }

        public HeaderViewModel()
        {

        }

        public HeaderViewModel(HeaderModel headerModel)
        {
            _headerModel = headerModel;
        }
        
    }
}

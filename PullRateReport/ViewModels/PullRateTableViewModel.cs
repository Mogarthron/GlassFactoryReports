using PullRateReport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PullRateReport.ViewModels
{
    public class PullRateTableViewModel: INotifyPropertyChanged
	{
		public List<PullRateTableModel> pullRates = new List<PullRateTableModel>();

		public PullRateTableViewModel()
		{

		}

		event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
		{
			add
			{
				throw new NotImplementedException();
			}

			remove
			{
				throw new NotImplementedException();
			}
		}
	}
}

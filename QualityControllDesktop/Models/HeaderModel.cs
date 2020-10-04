using System;
using System.Collections.Generic;
using System.Text;

namespace QualityControllDesktop.Models
{
    public class HeaderModel
    {
		private int _stanowisko;
		private List<string> _asortyment;
		private List<string> _sortujacy;
		private int _czasDoWylogowania;

		public int Stanowisko
		{
			get { return _stanowisko; }			
		}		

		public List<string> Asortyment
		{
			get { return _asortyment; }
			set { _asortyment = value; }
		}	

		public List<string> Sortujacy
		{
			get { return _sortujacy; }
			set { _sortujacy = value; }
		}	

		public int CzasDoWylogowania
		{
			get { return _czasDoWylogowania; }
			set { _czasDoWylogowania = value; }
		}

		public int SetTimeToLogOut(int timeToLogOut = 90)
		{
			return timeToLogOut;
		}

		public HeaderModel(int stanowisko, int czasDoWylogowania = 90)
		{
			_stanowisko = stanowisko;
			_czasDoWylogowania = czasDoWylogowania;

			_sortujacy = new List<string>()
			{
				"Pani_Sor1",
				"Pani_Sor2",
				"Pani_Sor3",
				"Pani_Sor4"
			};

			_asortyment = new List<string>()
			{
				"121212_1212",
				"121212_1300",
				"121212_1330",
				"121212_1400"
			};
		}
	}
}

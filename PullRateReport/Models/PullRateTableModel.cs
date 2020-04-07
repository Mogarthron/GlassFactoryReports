using System;
using System.Collections.Generic;
using System.Text;

namespace PullRateReport.Models
{
    public class PullRateTableModel
    {
		private int _id;
		private DateTime _Data;
		private char[] _ZasypWE;
		private char[] _PoziomWE;

		public int id
		{
			get { return _id; }
			set { _id = value; }
		}		

		public DateTime Data
		{
			get { return _Data; }
			set { _Data = value; }
		}		
			
		public char[] ZasypWE
		{
			get { return _ZasypWE; }
			set { _ZasypWE = value; }
		}		

		public char[] PoziomWE
		{
			get { return _PoziomWE; }
			set { _PoziomWE = value; }
		}

		private int _Moc;

		public int Moc
		{
			get { return _Moc; }
			set { _Moc = value; }
		}

		private bool _BaniakWE;

		public bool BaniakWE
		{
			get { return _BaniakWE; }
			set { _BaniakWE = value; }
		}

		public PullRateTableModel()
		{

		}

	}
}

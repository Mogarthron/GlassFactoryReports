using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary
{
    public class CommentsDT:IDClass
    {
        #region Private Prop
        private DateTime _Date;
		private string _Category;
		private string _Discription;
        #endregion

        #region PublicProp
        public DateTime Date
		{
			get { return _Date; }
			set { _Date = value; }
		}

		

		public string Category
		{
			get { return _Category; }
			set { _Category = value; }
		}

		

		public string Discription
		{
			get { return _Discription; }
			set { _Discription = value; }
		}
        #endregion

        public CommentsDT(int iD, DateTime date, string category, string discription)
		{
			SetID(iD);
			_Date = date;
			_Category = category;
			_Discription = discription;
		}
	}
}

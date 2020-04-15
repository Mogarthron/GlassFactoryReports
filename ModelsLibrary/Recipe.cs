using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary
{
    public class Recipe : IDClass
    {		
		private DateTime _Date;
		private string _CreationDate;
		private string _RecipeName;
		private bool _Active;
		private string _Comments;		

		#region publicProp
			   
		public string CreationDate
		{
			get { return _CreationDate; }
			set { _CreationDate = value; }
		}

		public string RecipeName
		{
			get { return _RecipeName; }
			set { _RecipeName = value; }
		}

		public bool Active
		{
			get { return _Active; }
			set { _Active = value; }
		}
		
		public string Comments
		{
			get { return _Comments; }
			set { _Comments = value; }
		}

        #endregion
			   		 
        public Recipe( int Id, DateTime dateTime, string Name, bool Active, string Comments)
		{
			SetID(Id);
			_Date = dateTime;
			_CreationDate = dateTime.ToShortDateString();
			_RecipeName = Name;
			_Active = Active;
			_Comments = Comments;
		}

	}
}

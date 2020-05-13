using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary
{
    public class Material : IDClass
    {
		private string _MaterialName;
		private string _MaterialCode;
		private string _Comments;

		public string MaterialName
		{
			get { return _MaterialName; }
			set { _MaterialName = value; }
		}		

		public string MaterialCode
		{
			get { return _MaterialCode; }
			set { _MaterialCode = value; }
		}		

		public string Comments
		{
			get { return _Comments; }
			set { _Comments = value; }
		}


		public Material(int _id, string _name, string _code, string _comments)
		{
			SetID(_id);
			_MaterialName = _name;

			if (String.IsNullOrEmpty(_code))
			{
				_MaterialCode = "";
			}
			else
			{
				_MaterialCode = _code;
			}

			if (String.IsNullOrEmpty(_comments))
			{
				_Comments = "";
			}
			else
			{
				_Comments = _comments;
			}			
		}
	}
}

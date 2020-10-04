using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QualityControllDesktop.Models
{
    public class QualityButtonModel
    {
        #region PrivateProp

        private int _Height;

        private int _Width;

        private string _Name;

        private int _id_Defect;

        private List<string> _LayersOfText;
        #endregion

        #region PublicProp
        
        public string TBAsortyment = "";
        public string TBSortyjacy = "";


        public List<string> LayersOfText
        {
            get { return _LayersOfText; }
            set { _LayersOfText = value; }
        }


        public int id_Defect
        {
            get { return _id_Defect; }
            set { _id_Defect = value; }
        }


        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }


        public int Width
        {
            get { return _Width; }
            set { _Width = value; }
        }

        public int Height
        {
            get { return _Height; }
            set { _Height = value; }
        }
        #endregion
                
        /// <summary>
        /// Basic ctor
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="name">if many words use '_' for separator</param>
        /// <param name="id_Defect"></param>
        public QualityButtonModel(int[] hewi, string name, int id_Defect)
        {
            string[] rows = name.Split('_');

            _Height = hewi[0];
            _Width = hewi[1];
            _Name = name;            
            _LayersOfText = rows.ToList();
            _id_Defect = id_Defect;
        }
    }
}

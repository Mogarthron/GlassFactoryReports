using QualityControllDesktop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QualityControllDesktop
{
    public class ButtonsMenager
    {
        private string _Kategoria;

        public string Kategoria
        {
            get { return _Kategoria; }
            set { _Kategoria = value; }
        }

        private string _NazwaWady;

        public string NazwaWady
        {
            get { return _NazwaWady; }
            set { _NazwaWady = value; }
        }

        private int _idWady;

        public int idWady
        {
            get { return _idWady; }
            set { _idWady = value; }
        }


        public ButtonsMenager(string kategoria, string nazwaWady)
        {
            _Kategoria = kategoria;
            _NazwaWady = nazwaWady;
        }


        //private static int[] hw = { 50, 80 };        

        //public List<QualityButtonModel> WadyMasyBezbarwnej = new List<QualityButtonModel>()
        //{
        //    new QualityButtonModel(hw, "Pecherz_Pojedynczy", 1),
        //    new QualityButtonModel(hw, "Skupisko_pecherzy", 2),
        //    new QualityButtonModel(hw, "Smuga_Barwna", 3),
        //    new QualityButtonModel(hw, "Smuga_Bezbarwa", 4),
        //    new QualityButtonModel(hw, "Kamien", 5),
        //    new QualityButtonModel(hw, "Brak_inny_nieOpisany", 6)
        //};

        //public List<QualityButtonModel> WadyMasyOpalowej = new List<QualityButtonModel>()
        //{
        //    new QualityButtonModel(hw, "Pecherz_Pojedynczy", 7),
        //    new QualityButtonModel(hw, "Skupisko_pecherzy", 8),
        //    new QualityButtonModel(hw, "Smuga_Barwna", 9),
        //    new QualityButtonModel(hw, "Smuga_Bezbarwa", 10),
        //    new QualityButtonModel(hw, "Kamien", 11),
        //    new QualityButtonModel(hw, "Brak_inny_nieOpisany", 12)
        //};

        //public List<QualityButtonModel> WadyHutnicze = new List<QualityButtonModel>()
        //{
        //    new QualityButtonModel(hw, "Pecherz_Pojedynczy", 13),
        //};
    }
}

using QualityControllDesktop.ViewModels;
using QualityControllDesktop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace QualityControllDesktop
{
    public class BusinessLogic
    {
        static List<string> Kategoria = new List<string>()
        {
            "WadyMasyBezbarwnej",
            "WadyMasyOpalowej",
            "WadyHutnicze",
            "WadyInne"
        };

        static List<string> NazwaWady = new List<string>()
        {
            "Pecherz_Pojedynczy",
            "Skupisko_Pecherzy",
            "Smuga_Cieka_Barwna",

        };

        List<ButtonsMenager> buttonsMenager = new List<ButtonsMenager>()
        {
            new ButtonsMenager(Kategoria[0], NazwaWady[0])
        };

        public void AddHeader(Grid grid)
        {
            HeaderModel model = new HeaderModel(1);
            HeaderViewModel viewModel = new HeaderViewModel(model);
            

            grid.Children.Add(viewModel.SetHeader());
        }

        public void AddBtns(WrapPanel wrapPanel)
        {
            int[] hewi = { 50, 80 };

            List<QualityButtonModel> models = new List<QualityButtonModel>()
            {
                new QualityButtonModel(hewi, buttonsMenager[0].NazwaWady , buttonsMenager.IndexOf(buttonsMenager[0])),
                new QualityButtonModel(hewi, "Skupisko_pecherzy",12),
                new QualityButtonModel(hewi, "Smuga_Barwna",13),
                new QualityButtonModel(hewi, "Smuga_Bezbarwa",14),
                new QualityButtonModel(hewi, "Kamien",15),
                new QualityButtonModel(hewi, "Brak_inny_nieOpisany",16)
            };

            models.ForEach(x =>
            {
                var vm = new QualityButtonViewModel(x);
                wrapPanel.Children.Add(vm.SetButton());
            });            
        }        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class tRecipeComposition
    {
        public List<tRawMaterial> rawMaterials; 

        private tRawMaterial Piasek;
        
        
        public float SumOfMaterials()
        {
            float sum = 0f;

            foreach(tRawMaterial r in rawMaterials)
            {
                sum += r.Quantity;
            }

            return sum;
        }

        public List<tRawMaterial> MasComposition()
        {
            List<tRawMaterial> masComposition = new List<tRawMaterial>();

            float sum = 0f;

            foreach (tRawMaterial r in rawMaterials)
            {
                sum += r.Quantity;
            }

            foreach(tRawMaterial r in rawMaterials)
            {
                masComposition.Add(new tRawMaterial(r.Name, r.Quantity / sum));
            }

            return masComposition; 
        }

        public tRecipeComposition()
        {
            tOxide SiO2 = new tOxide("SiO2", 99f);
            
            tOxide PSiO2 = SiO2;
            PSiO2.Quantity = 0.996f;

            Piasek = new tRawMaterial("Piasek szklarski kl. 1", 150f);
            Piasek.Compound.Add(PSiO2);

            rawMaterials = new List<tRawMaterial>()
            {
                Piasek,
                new tRawMaterial("Soda ciężka", 33.3f),
                new tRawMaterial("Węglan potasu", 15f),
                new tRawMaterial("Wodorotlenek glinu", 19.5f),
                new tRawMaterial("Azotan Sodu", 4.5f),
                new tRawMaterial("Trójfosforan sodu", 1.5f),
                new tRawMaterial("Tlenek cynku", 4.5f),
                new tRawMaterial("Węglan litu", 0.5f),
                new tRawMaterial("Siarczan sodu", 3f),
                new tRawMaterial("Boraks pięciowodny", 6f),
                new tRawMaterial("Kriolit", 3.3f),
                new tRawMaterial("Trójtlenek antymonu", 1.5f)
            };
        }
    }
}

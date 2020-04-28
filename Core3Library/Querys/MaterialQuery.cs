using System;
using System.Collections.Generic;
using System.Text;
using ModelsLibrary;

namespace Core3Library.Querys
{
    public class MaterialQuery
    {
        DBConnection dB = new DBConnection();
        List<Material> materials = new List<Material>();

        List<string> sp = new List<string>()
        {   
            "dbo.spTowary_PokazTowary",            
            "dbo.spTowary_DadajTowar"
        };

        public List<Material> ShowMaterials()
        {
            materials.Clear();

            dB.StartConnection(sp[0]);

            while (dB.dataReader.Read())
            {
                materials.Add(new Material(dB.dataReader.GetInt32(0), dB.dataReader.GetString(1), dB.dataReader.GetString(2), dB.dataReader.GetString(3)));
            }

            dB.EndConnection();

            return materials;
        }

        public void InsertMaterial(string _name, string _code, string _comments)
        {
            dB.AddParameterToList("@Nazwa", System.Data.SqlDbType.NVarChar, _name);
            dB.AddParameterToList("@Kod", System.Data.SqlDbType.NVarChar, _code);
            dB.AddParameterToList("Uwagi", System.Data.SqlDbType.NVarChar, _comments);

            dB.Connection(sp[1]);
        }

        public MaterialQuery()
        {

        }
    }
}

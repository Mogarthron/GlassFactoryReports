using System;
using System.Collections.Generic;
using System.Text;
using ModelsLibrary;

namespace Core3Library.Querys
{
    public class BatchQuery
    {
        DBConnection dB = new DBConnection();
        List<Batch> batches = new List<Batch>();

        List<string> sp = new List<string>()
        {
            "dbo.spZestawy_DodajZestaw",
            "dbo.spZestawy_PokazWszystko"
        };

        

        public List<Batch> ShowBatches()
        {
            batches.Clear();

            dB.StartConnection(sp[1]);

            while (dB.dataReader.Read())
            {
                batches.Add(new Batch(dB.dataReader.GetInt32(0), dB.dataReader.GetDateTime(1), dB.dataReader.GetString(2), dB.dataReader.GetInt16(3)));
            }

            dB.EndConnection();

            return batches;
        }

        public void InsertBatch(DateTime _date, int _id_recipe, int _preparatedBatches)
        {
            dB.AddParameterToList("@DataPrzygotowania", System.Data.SqlDbType.Date, _date.ToShortDateString());
            dB.AddParameterToList("@id_Receptury", System.Data.SqlDbType.Int, _id_recipe);
            dB.AddParameterToList("@ZrobioneZestawy", System.Data.SqlDbType.SmallInt, _preparatedBatches);

            dB.Connection(sp[0]);
        }

        public BatchQuery()
        {

        }

    }
}

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
            "dbo.spZestawy_PokazWszystko",
            "dbo.spZestawy_PokazZakres"
        }; 
        
        public List<Batch> ShowRange(DateTime date1, DateTime date2)
        {
            batches.Clear();

            dB.AddParameterToList("@Date1", System.Data.SqlDbType.Date, date1/*.ToShortDateString()*/);
            dB.AddParameterToList("@Date2", System.Data.SqlDbType.Date, date2/*.ToShortDateString()*/);

            dB.StartConnection(sp[2]);

            while (dB.dataReader.Read())
            {
                batches.Add(new Batch(dB.dataReader.GetDateTime(0), dB.dataReader.GetString(1), dB.dataReader.GetInt16(2)));
            }

            dB.EndConnection();
            return batches;
        }

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

        public void InsertBatch(DateTime date, int id_recipe, int preparatedBatches)
        {
            dB.AddParameterToList("@DataPrzygotowania", System.Data.SqlDbType.Date, date.ToShortDateString());
            dB.AddParameterToList("@id_Receptury", System.Data.SqlDbType.Int, id_recipe);
            dB.AddParameterToList("@ZrobioneZestawy", System.Data.SqlDbType.SmallInt, preparatedBatches);

            dB.Connection(sp[0]);
        }

        public BatchQuery()
        {

        }

    }
}

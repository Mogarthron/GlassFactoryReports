using System;
using System.Collections.Generic;
using System.Text;
using ModelsLibrary;

namespace Core3Library.Querys
{
    public class CommentsDTQuery
    {
        DBConnection dB = new DBConnection();
        List<CommentsDT> comments = new List<CommentsDT>();
        List<string> sp = new List<string>()
        {
            "dbo.spUwagiDT_PokazWysztkie",
            "dbo.spUwagiDT_DodajUwage"
        };

        public List<CommentsDT> ShowAllComments()
        {
            comments.Clear();

            dB.StartConnection(sp[0]);

            while (dB.dataReader.Read())
            {
                comments.Add(new CommentsDT(dB.dataReader.GetInt32(0), dB.dataReader.GetDateTime(1), dB.dataReader.GetString(2), dB.dataReader.GetString(3)));
            }

            dB.EndConnection();

            return comments;
        }

        public void AddComment(DateTime _date, string _title, string _discription)
        {
            dB.AddParameterToList("@Data", System.Data.SqlDbType.Date, _date);
            dB.AddParameterToList("@Dotyczy", System.Data.SqlDbType.NVarChar, _title);
            dB.AddParameterToList("@Opis", System.Data.SqlDbType.Text, _discription);

            dB.Connection(sp[1]);
        }
    }
}

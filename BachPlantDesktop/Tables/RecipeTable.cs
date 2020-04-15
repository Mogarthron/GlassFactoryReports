using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ModelsLibrary;
using Core3Library;

namespace BachPlantDesktop.Tables
{
    public class RecipeTable
    {        
        DBConnection DB = new DBConnection();

        DataTable AdminTable = new DataTable("UserRecipeTable");
        
        DataColumn EntryDate = new DataColumn( "Data Wprowadzenia", Type.GetType("System.DateTime"));
        DataColumn RecipeName = new DataColumn("Receptura", Type.GetType("System.String"));
        DataColumn IsActive = new DataColumn("Aktywna", Type.GetType("System.Boolean"));
        DataColumn Comments = new DataColumn("Uwagi", Type.GetType("System.String"));
        DataRow row;

        public RecipeTable()
        {
            AdminTable.Columns.Add(EntryDate);
            AdminTable.Columns.Add(RecipeName);
            AdminTable.Columns.Add(IsActive);
            AdminTable.Columns.Add(Comments);
        }
    }
}

using System;
using System.Data;
using System.Text;
using System.Collections.Generic;

namespace UtilityMethods.Models;

public class Utility
{

    // Convert List to DataSet
    public static DataSet ConvertListToDataSet<T>(List<T> list, string tableName)
    {
        // Create a new DataSet
        DataSet dataSet = new DataSet();

        // Create a DataTable with the specified table name
        DataTable dataTable = new DataTable(tableName);

        // Get the type of objects in the list
        Type objectType = typeof(T);

        // Get the properties of the object type
        var properties = objectType.GetProperties();

        // Add columns to the DataTable based on the object properties
        foreach (var property in properties)
        {
            Type? columnType = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
            dataTable.Columns.Add(property.Name, columnType);
        }

        // Add rows to the DataTable based on the list items
        foreach (var item in list)
        {
            DataRow row = dataTable.NewRow();
            foreach (var property in properties)
            {
                object? value = property.GetValue(item);
                row[property.Name] = value ?? DBNull.Value;
            }
            dataTable.Rows.Add(row);
        }

        // Add the DataTable to the DataSet
        dataSet.Tables.Add(dataTable);

        return dataSet;
    }


    // Convert DataSet to Xml
    public static string ConvertDataSetToXml(DataSet dataSet)
    {
        // Convert the DataSet to XML
        StringBuilder xmlBuilder = new StringBuilder();
        using (System.IO.StringWriter writer = new System.IO.StringWriter(xmlBuilder))
        {
            dataSet.WriteXml(writer);
        }

        return xmlBuilder.ToString();
    }


    // Convert DataTable to Dynamic List
    public static List<Dictionary<string, object>> ConvertDataTableToList(DataTable table)
    {
        //var lst = dt.AsEnumerable().ToList();
        var lst = table.AsEnumerable()
                     .Select(r => r.Table.Columns.Cast<DataColumn>()
                     .Select(c => new KeyValuePair<string, object>(c.ColumnName, r[c.Ordinal])
                  ).ToDictionary(z => z.Key, z => z.Value)
               ).ToList();

        return lst;
    }
}
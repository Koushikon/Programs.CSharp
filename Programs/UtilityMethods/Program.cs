using System;
using System.Data;
using System.Text;
using System.Collections.Generic;
using UtilityMethods.Models;

namespace UtilityMethods;

public class Program
{
    public static void Main()
    {
        #region Ready example DataSet/DataTable
        // Create a new DataSet
        DataSet dataSet = new DataSet("MyDataSet");

        // Create a DataTable
        DataTable dataTable = new DataTable("MyDataTable");

        // Add columns to the DataTable
        dataTable.Columns.Add("ID", typeof(int));
        dataTable.Columns.Add("Name", typeof(string));
        dataTable.Columns.Add("Age", typeof(int));

        // Add rows to the DataTable
        dataTable.Rows.Add(1, "John Doe", 30);
        dataTable.Rows.Add(2, "Jane Smith", 25);
        dataTable.Rows.Add(3, "Bob Johnson", 40);

        // Add the DataTable to the DataSet
        dataSet.Tables.Add(dataTable);
        #endregion

        #region Ready example List
        // Create a list of Person objects
        List<Person> personList = new List<Person>()
        {
            new Person { ID = 1, Name = "John Doe", Age = 30 },
            new Person { ID = null, Name = null, Age = null },
            new Person { ID = 3, Name = "Bob Johnson", Age = 40 }
        };
        #endregion

        Console.WriteLine("\n" + new string('-', 10) + "\n");

        Print_ConvertDataSetToXml(dataSet);
        Console.WriteLine("\n" + new string('-', 10) + "\n");


        Print_ConvertListToDataSet(personList);
        Console.WriteLine("\n" + new string('-', 10) + "\n");


        Print_ConvertDataTableToList(dataTable);
        Console.WriteLine("\n" + new string('-', 10) + "\n");
    }

    public static void Print_ConvertDataSetToXml(DataSet dataSet)
    {
        // Convert the DataSet to XML
        string xmlString = Utility.ConvertDataSetToXml(dataSet);

        // Display the XML string
        Console.WriteLine(xmlString);
    }

    public static void Print_ConvertListToDataSet(List<Person> personList)
    {
        // Convert the list to a DataSet
        DataSet dataSet1 = Utility.ConvertListToDataSet(personList, "PersonTable");

        // Display the DataTable from the DataSet
        DataTable dataTable1 = dataSet1.Tables["PersonTable"]!;
        foreach (DataRow row in dataTable1.Rows)
        {
            Console.WriteLine($"ID: {row["ID"]}, Name: {row["Name"]}, Age: {row["Age"]}");
        }
    }

    public static void Print_ConvertDataTableToList(DataTable dataTable)
    {
        var ListDynamicObj = Utility.ConvertDataTableToList(dataTable);
        foreach (var item in ListDynamicObj)
        {
            Console.WriteLine($"ID: {item["ID"]}, Name: {item["Name"]}, Age: {item["Age"]}");
        }
    }
}

public class Person
{
    public int? ID { get; set; }
    public string? Name { get; set; } // Nullable reference type
    public int? Age { get; set; }
}
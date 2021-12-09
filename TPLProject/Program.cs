using System;

namespace TPLProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Read data from csv and write data in csv");
            //CsvHandler.ImplementCsvdatHandling();
            //Console.WriteLine();

            //Console.WriteLine("Read data from csv and write data in json");
            //ReadCSV_And_WriteJSON.ImplementCsvdatHandling();
            //Console.WriteLine();

            Console.WriteLine("Read data from json and write data in csv");
            ReadJson_And_WriteCsv.ImplementJsonToCsv();
            Console.WriteLine();



        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;

namespace TPLProject
{
    class CsvHandler
    {
        public static void ImplementCsvdatHandling()
        {
            string importFilePath = @"E:\ThirdPartyLiabrary\ThirdPartyLiabrary\TPLProject\Utility\addresses.csv";
            string exportFilePath = @"E:\ThirdPartyLiabrary\ThirdPartyLiabrary\TPLProject\Utility\export.csv";
            // Reading csv file
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Addresses>().ToList();
                Console.WriteLine("Read data succesfully from addresses csv");
                foreach (Addresses addressData in records)

                {
                    Console.WriteLine("\t" + addressData.firstname);
                    Console.WriteLine("\t" + addressData.lastname);
                    Console.WriteLine("\t" + addressData.address);
                    Console.WriteLine("\t" + addressData.city);
                    Console.WriteLine("\t" + addressData.state);
                    Console.WriteLine("\t" + addressData.code);
                    Console.Write("\n");
                }

                Console.WriteLine("\n  now reading from csv file & write to csv file");
                //Writing csv file
                using (var writer = new StreamWriter(exportFilePath))
                using (var CsvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    CsvExport.WriteRecords(records);
                }
            }
        }
    }
}

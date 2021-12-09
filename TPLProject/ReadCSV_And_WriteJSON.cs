using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace TPLProject
{
    class ReadCSV_And_WriteJSON
    {
        public static void ImplementCsvdatHandling()
        {
            string importFilePath = @"E:\ThirdPartyLiabrary\ThirdPartyLiabrary\TPLProject\Utility\addresses.csv";
            string exportFilePath = @"E:\ThirdPartyLiabrary\ThirdPartyLiabrary\TPLProject\Utility\export.json";
            // Reading csv file
            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Addresses>().ToList();
                Console.WriteLine("Read data succesfully from addresses csv , here are codes");
                foreach (Addresses addressData in records)
                {
                    Console.WriteLine("\t" + addressData.firstname);
                    Console.WriteLine("\t" + addressData.lastname);
                    Console.WriteLine("\t" + addressData.address);
                    Console.WriteLine("\t" + addressData.city);
                    Console.WriteLine("\t" + addressData.state);
                    Console.WriteLine("\t" + addressData.code);
                }
                Console.WriteLine("\n*****************Now reading from csv fifle and writing to JSON file ********************");

                //Write data to json file 
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(exportFilePath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, records);
                }
            }
        }

        
        
    }
}



            

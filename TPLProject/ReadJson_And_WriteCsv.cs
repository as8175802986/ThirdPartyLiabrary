using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.IO;
using System.Linq;

namespace TPLProject
{
    class ReadJson_And_WriteCsv
    {
        public static void ImplementJsonToCsv()
        {

            string importFilePath = @"E:\ThirdPartyLiabrary\ThirdPartyLiabrary\TPLProject\Utility\export.json";
            string exportFilePath = @"E:\ThirdPartyLiabrary\ThirdPartyLiabrary\TPLProject\Utility\jsonfile.csv";
            IList<Addresses> addressData = JsonConvert.DeserializeObject<IList<Addresses>>(File.ReadAllText(importFilePath));
            Console.WriteLine("Reading From Json File And Write To Csv File\n");


            using (var writer = new StreamWriter(exportFilePath))
            using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvExport.WriteRecords(addressData);
            }
        }
    }
}
    


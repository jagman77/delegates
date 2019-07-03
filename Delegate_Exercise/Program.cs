using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using FileParserNetStandard;

public delegate List<List<string>> Parser(List<List<string>> data);

namespace Delegate_Exercise {
 
    
    internal class Delegate_Exercise
    {
        public static void Main(string[] args)
        {

            string csvPath = @"D:\Code\UNI\weeklytasks\Delegates\Files\Files\data.csv";
            string writePath = @"D:\Code\UNI\weeklytasks\Delegates\Files\Files\write.csv";

            var ch = new CsvHandler();

            ch.ProcessCsv(csvPath, writePath, (data) => data);

            Console.ReadKey();

        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using FileParserNetStandard;

namespace Delegate_Exercise {
    
    
    public class CsvHandler {
        
        /// <summary>
        /// Reads a csv file (readfile) and applies datahandling via dataHandler delegate and writes result as csv to writeFile.
        /// </summary>
        /// <param name="readFile"></param>
        /// <param name="writeFile"></param>
        /// <param name="dataHandler"></param>
        public void ProcessCsv(string readFile, string writeFile, Func<List<List<string>>, List<List<string>>> dataHandler) {

            var fh = new FileHandler();
            var dp = new DataParser();

            var data = fh.ReadFile(readFile);
            var processedData = fh.ParseCsv(data);

            dataHandler += dp.StripWhiteSpace;
            dataHandler += dp.StripQuotes;
            dataHandler += dp.StripHashTag;

            var handledData = dataHandler(processedData);

            fh.WriteFile(writeFile, ',', handledData);


        }
        
    }
}
﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace FileParserNetStandard {
    public class FileHandler {
       
        public FileHandler() { }

        /// <summary>
        /// Reads a file returning each line in a list.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public List<string> ReadFile(string filePath) {
            List<string> lines = new List<string>();

            lines = File.ReadAllLines(filePath).ToList();

            return lines;
        }

        
        /// <summary>
        /// Takes a list of a list of data.  Writes to file, using delimeter to seperate data.  Always overwrites.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="delimeter"></param>
        /// <param name="rows"></param>
        public void WriteFile(string filePath, char delimeter, List<List<string>> rows)
        {
            StreamWriter sw = new StreamWriter(filePath);

            foreach (List<string> row in rows)
            {
                string csv = string.Join(delimeter.ToString(), row);
                sw.WriteLine(csv);
            }

            sw.Close();
        }
        
        /// <summary>
        /// Takes a list of strings and seperates based on delimeter.  Returns list of list of strings seperated by delimeter.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="delimeter"></param>
        /// <returns></returns>
        public List<List<string>> ParseData(List<string> data, char delimeter) {

            List<List<string>> results = new List<List<string>>();
            for (int i = 0; i < data.Count; i++)
            {
                results.Add(data[i].Split(delimeter).ToList());
            }

            return results;  //-- return result here
        }
        
        /// <summary>
        /// Takes a list of strings and seperates on comma.  Returns list of list of strings seperated by comma.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<List<string>> ParseCsv(List<string> data) {
            
            List<List<string>> results = new List<List<string>>();
            for (int i = 0; i < data.Count; i++)
            {
                results.Add(data[i].Split(',').ToList());
            }

            return results;  //-- return result here
        }
    }
}
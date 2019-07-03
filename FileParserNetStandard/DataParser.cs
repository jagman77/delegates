﻿using System.Collections.Generic;
using System.Linq;

namespace FileParserNetStandard {
    public class DataParser {
        

        /// <summary>
        /// Strips any whitespace before and after a data value.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<List<string>> StripWhiteSpace(List<List<string>> data) 
        {

            for (int i = 0; i < data.Count; i++)
            {
                for (int index = 0; index < data[i].Count; index++)
                {
                    data[i][index] = new string(data[i][index].Where(c => !char.IsWhiteSpace(c)).ToArray());
                }
            }  
           
            return data;
        }
        /// <summary>
        /// Strips quotes from beginning and end of each data value
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<List<string>> StripQuotes(List<List<string>> data) {

            for (int i = 0; i < data.Count; i++)
            {
                for (int index = 0; index < data[i].Count; index++)
                {
                    data[i][index] = new string(data[i][index].Where(c => !c.Equals("\"")).ToArray());
                }
            }

            return data;
        }

        public List<List<string>> StripHashTag(List<List<string>> data)
        {

            for (int i = 0; i < data.Count; i++)
            {
                for (int index = 0; index < data[i].Count; index++)
                {
                    data[i][index] = new string(data[i][index].Where(c => !c.Equals("#")).ToArray());
                }
            }

            return data;
        }

    }
}
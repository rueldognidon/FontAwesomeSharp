using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeGenerator{
    public class FontAwesomeMap{
        public static Dictionary<string, string> GetNameValuePair(string content){

            var items = content.Split("\r\n").ToList();
            
            var fieldNames = items.Where((c, i) => i % 2 == 0).Select(ReformatName).ToArray();
            var fieldValues = items.Where((c, i) => i % 2 != 0).ToArray();
            Array.ForEach(fieldNames, Console.WriteLine);
            Array.ForEach(fieldValues, Console.WriteLine);

            var result = new Dictionary<string, string>();
            var ctr = 0;
            foreach(var item in fieldNames){
                result.Add(item, fieldValues[ctr]);
                ctr++;
            }
            return result;
        }

        public static string ReformatName(string input)
        {
            return String.Join("",input.Split("-").Select(x=>x.First().ToString().ToUpper() + new string(x.Skip(1).ToArray())));
        }
    }
}
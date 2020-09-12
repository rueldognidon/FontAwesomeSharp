using System;
using System.IO;
using System.Reflection;

namespace CodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var solidContent = FileContent.GetRegularData();

            var fieldData = FontAwesomeMap.GetNameValuePair(solidContent);

            foreach(var field in fieldData){
                Console.WriteLine($"public static readonly FontAwesomeSolidIcon {field.Key} = \"\\u{field.Value.ToUpper()}\";");
            }
        }
    }

}

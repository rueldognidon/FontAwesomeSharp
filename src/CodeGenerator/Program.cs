using System;
using System.IO;
using System.Reflection;

namespace CodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var solidContent = FileContent.GetSolidData();

            Console.WriteLine(solidContent);
        }
    }
}

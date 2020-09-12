using System.IO;
using System.Reflection;

namespace CodeGenerator
{
    public static class FileContent
    {
        public static string GetSolidData()
        {
            var assembly = typeof(FileContent).GetTypeInfo().Assembly;
            Stream solidDump = assembly.GetManifestResourceStream("CodeGenerator.FADataDump.fa-solid-dump.dat");

            var streamReader = new StreamReader(solidDump);
            var content = streamReader.ReadToEnd();
            return content;
        }

        public static string GetRegularData()
        {

            var assembly = typeof(FileContent).GetTypeInfo().Assembly;
            Stream solidDump = assembly.GetManifestResourceStream("CodeGenerator.FADataDump.fa-regular-dump.dat");

            var streamReader = new StreamReader(solidDump);
            var content = streamReader.ReadToEnd();
            return content;
        }
    }
}
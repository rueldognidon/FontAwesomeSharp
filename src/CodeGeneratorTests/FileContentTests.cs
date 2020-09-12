using System;
using System.Diagnostics;
using CodeGenerator;
using NUnit.Framework;
using Shouldly;

namespace CodeGeneratorTests{
    public class FileContentTests{
        [Test]
        public void GetSolidData(){
            var result = FileContent.GetSolidData();
            Debug.WriteLine(result);
            result.Length.ShouldBeGreaterThan(0);
            Console.WriteLine(result);
        }

        [Test]
        public void GetRegularData(){
            var result = FileContent.GetRegularData();
            Debug.WriteLine(result);
            result.Length.ShouldBeGreaterThan(0);
        }
    }
}

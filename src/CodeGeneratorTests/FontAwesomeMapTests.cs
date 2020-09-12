using System;
using System.Diagnostics;
using System.Linq;
using CodeGenerator;
using NUnit.Framework;
using Shouldly;

namespace CodeGeneratorTests{
    public class FontAwesomeMapTests{
        [Test]
        public void GetNameValuePair()
        {
            const string input = "ad\r\nf641\r\naddress-book\nf2b9";

            var result = FontAwesomeMap.GetNameValuePair(input);

            result.Count.ShouldBe(2);
            result.First().Key.ShouldBe("Ad");
        }
        
        [Test]
        public void GetNameValuePair_RealData()
        {
            var input = FileContent.GetSolidData();

            var result = FontAwesomeMap.GetNameValuePair(input);

            result.First().Key.ShouldBe("Ad");
        }

        [Test]
        public void ReformatName(){
            var input = "address-book";

            var result = FontAwesomeMap.ReformatName(input);

            Debug.WriteLine(result);

            result.ShouldBe("AddressBook");
        }
    }
}
using System;
using System.Diagnostics;
using CodeGenerator;
using NUnit.Framework;
using Shouldly;

namespace CodeGeneratorTests{
    public class FontAwesomeMapTests{
        [Test]
        public void GetNameValuePair()
        {
            const string input = "ad\nf641\naddress-book\nf2b9";

            var result = FontAwesomeMap.GetNameValuePair(input);

            result.Count.ShouldBe(2);
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
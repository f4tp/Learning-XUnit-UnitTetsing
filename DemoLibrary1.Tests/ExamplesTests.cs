using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DemoLibrary;

namespace DemoLibrary1.Tests
{
    public class ExamplesTests
    {

        [Fact]
        //the connected method tests that a string is longer than 10 chars long.. which defines whether a file has loaded correctly or not (so it throws an exception)
        public void ExampleLoadTextFile_ValidNameShouldWork()
        {
            string actual = Examples.ExampleLoadTextFile("This is a valid filename");
            Assert.True(actual.Length > 0);
        }

    }
}

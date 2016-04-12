using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace xUnitTestOutputHelper
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class Class1
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public Class1(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void OutputTest1()
        {
            _testOutputHelper.WriteLine("Some output!");

            false.Should().BeTrue();
        }

        [Fact]
        public void OutputTest2()
        {
            _testOutputHelper.WriteLine("No output!");

            true.Should().BeTrue();
        }
    }
}

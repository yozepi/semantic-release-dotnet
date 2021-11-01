using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExampleUnitTests
{
    [TestClass]
    public class ExampleUnitTests
    {
        [TestMethod]
        public void ExampleTest()
        {
            bool thisIsABool = true;
            thisIsABool.Should().BeTrue();
        }

        [TestMethod]
        public void AnotherTest()
        {
            bool anotherBool = true;
            anotherBool.Should().BeTrue();
        }
    }
}

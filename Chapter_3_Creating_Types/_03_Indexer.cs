using System.Security.Cryptography;

namespace Chapter_3_Creating_Types
{
    /// <summary>
    /// Indexers provide a syntax for accessing element of a class or struct. they are 
    /// like properies, but they can be accessed via index rather than a property name
    /// </summary>
    public class IndexerTestClass
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            string s = "Hello";

            //Act

            var s1 = s[0];

            //Assert

            Assert.Equal("H", s1.ToString());

        }
    }
}
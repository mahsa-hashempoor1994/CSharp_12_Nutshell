using System.Security.Cryptography;

namespace Chapter_3_Creating_Types
{
    /// <summary>
    /// Indexers provide a syntax for accessing element of a class or struct. they are 
    /// like properies, but they can be accessed via index rather than a property name.
    /// Using indexers is similar to how we can access to an array. The only diffrent between them is that 
    /// the index element can be any type , but the index of an array is only int.
    /// a["Key"]=value
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

        [Fact]
        public void CreateIndexer()
        {
            //Arrange
            Sentence s = new Sentence();

            //Act

            var s3 = s[3];

            //Assert

            Assert.Equal("fox", s3.ToString());

        }

    }
    public class Sentence
    {
         string[] words = "The quick brown fox".Split();

        public string this [int wordNum]
        {
            get { return words[wordNum]; }
            set { words[wordNum] = value; }
        }
    }
}
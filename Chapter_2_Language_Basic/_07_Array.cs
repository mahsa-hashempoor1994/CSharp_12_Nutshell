

namespace Chapter_2_Language_Basic
{

    public class ArrayTestClass
    {

        [Fact]
        public void ArrayTest1()
        {
            // Arrange
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};
            
            // Act
            char result = vowels[0];

            // Assert
            Assert.Equal('a', result);
            
        }

        /// <summary>
        /// Indices was introduced in C#8 
        /// </summary>
        [Fact]
        public void ArrayIndices()
        {
            // Arrange
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};


            // Act
            char lastElement = vowels[^1];
            char secondToLastElement = vowels[^2];

            // Assert
            Assert.Equal('u', lastElement);
            Assert.Equal('o', secondToLastElement);


        }

        /// <summary>
        /// Ranges was introduced in C#8
        /// </summary>
        [Fact]
        public void ArrayRanges()
        {
            // Arrange
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};

            Index first = 0;
            Index last = ^1;
            
            // Act
            char firstElement = vowels[first]; // 'a'
            char lastElement = vowels[last];  //  'u'
            char[] firstTwo = vowels[..2];   // 'a', 'e'
            char[] firstThree = vowels[..3];   // 'a', 'e' ,'i'
            char[] lastThree = vowels[2..];  // 'i', 'o', 'u'
            char[] middleOne = vowels[2..3];  // 'i'


            // Assert
            Assert.Equal('a', firstElement);
            Assert.Equal('u', lastElement);
            Assert.Equal(new char[] { 'a', 'e' }, firstTwo);
            Assert.Equal(new char[] { 'a', 'e', 'i' }, firstThree);
            Assert.Equal(new char[] { 'i', 'o', 'u' }, lastThree);
            Assert.Equal(new char[] { 'i' }, middleOne);


        }

        [Fact]
        public void RectangularArraysTest()
        {
            // Arrange
            int[,] matrix = new int[3, 3];

            // Act
            //The GetLength method of an array returns the length for a given dimension (starting at 0):
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = i * 3 + j;
            
            // Assert
            Assert.Equal(0, matrix[0, 0]);
            Assert.Equal(1, matrix[0, 1]);
            Assert.Equal(2, matrix[0, 2]);
            Assert.Equal(3, matrix[1, 0]);
            Assert.Equal(4, matrix[1, 1]);
            Assert.Equal(5, matrix[1, 2]);
            Assert.Equal(6, matrix[2, 0]);
            Assert.Equal(7, matrix[2, 1]);
            Assert.Equal(8, matrix[2, 2]);
        }
    }
}
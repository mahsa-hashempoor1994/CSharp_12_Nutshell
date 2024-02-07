

namespace Chapter_2_Language_Basic
{

    public class IncrementDecrementOperatorTestClass
    {

        [Fact]
        public void IncrementDecrementOperatorTests()
        {
            // Arrange
            int x = 0, y = 0;


            // Act
            int resultX = ++x; //x=1 and resultX=1
            int resultY = y++; // y=1 and resultY=0


            // Assert
            Assert.Equal(expected: 1, actual: resultX);
            Assert.Equal(expected: 1, x);
            Assert.Equal(expected: 1, y);
            Assert.Equal(expected: 0, resultY);
            Assert.Equal(resultX, x);
            Assert.NotEqual(resultY, y);

        }
    }
}
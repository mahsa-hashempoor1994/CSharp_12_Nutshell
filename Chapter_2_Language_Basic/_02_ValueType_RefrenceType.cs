using System.Drawing;

namespace Chapter_2_Language_Basic
{
    public class TestClass
    {

        [Theory]
        [InlineData(7)]
        public void ValueTypes_CopyCorrectly(int x)
        {
            // Arrange
            Point p1 = new Point { X = x };

            // Act
            Point p2 = p1;
            p1.X = 9;

            // Assert
            Assert.NotEqual(p1.X, p2.X);
        }
    }
}

namespace Chapter_2_Language_Basic
{
    public struct Point { public int X; public int Y; }

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
            Assert.True(p1.X!=p2.X);
            Assert.Equal(9, p1.X);
            Assert.Equal(7, p2.X);
        }
    }
}


namespace Chapter_2_Language_Basic
{
    public class PointClass { public int X; public int Y; }
    public class RefrenceTypeTestClass
    {

        [Theory]
        [InlineData(7)]
        public void RefrenceTypesTests(int x)
        {
            var b = 0b1010_1011_1100_1101_1110_1111;
            // Arrange
            PointClass p1 = new() { X = x };

            // Act
            PointClass p2 = p1;
            p1.X = 9;

            // Assert
            Assert.True(p1.X== p2.X);
            Assert.Equal(9, p1.X);
            Assert.Equal(9, p2.X);

        }
    }
}
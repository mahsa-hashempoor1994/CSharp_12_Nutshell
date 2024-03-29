

namespace Chapter_2_Language_Basic
{

    public class _09_Swich_Expression
    {

        [Fact]
        public void OverflowTests()
        {
            // Arrange
            int a = int.MinValue;
            int y = unchecked(int.MaxValue + 1);


            // Act
            a--;

            // Assert
            Assert.Equal(int.MaxValue, a);
            Assert.Equal(int.MinValue, y);

        }
    }
}
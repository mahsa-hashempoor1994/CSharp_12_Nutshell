

namespace Chapter_2_Language_Basic
{
   
    public class NumericConversionTestClass
    {

        [Fact]
        public void NumericConversionTests()
        {
            // Arrange
            long largeInteger = 1000000000000000000L; // 10^18


            // Act
            double floatingPoint = largeInteger; // Implicit conversion
            int i = (int)floatingPoint;

            // Assert
          
            Assert.NotEqual(largeInteger,i);
        }
    }
}
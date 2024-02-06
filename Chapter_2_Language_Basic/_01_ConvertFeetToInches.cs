namespace Chapter_2_Language_Basic
{
    public class FeetConverterTests
    {

        [Theory]
        [InlineData(0, 0)] // Test case for 0 feet
        [InlineData(1, 12)] // Test case for 1 foot
        [InlineData(5, 60)] // Test case for 5 feet
        [InlineData(100, 1200)] // Test case for 10 feet
        [InlineData(30, 360)] // Test case for 30 feet
        public void ConvertFeetToInches(int feet, int expectedInches)
        {
            // Arrange: Create a method to convert feet to inches
            int FeetToInches(int feet)
            {
                int inches = feet * 12;
                return inches;
            }
            //Act 
            int actualInches = FeetToInches(feet);

            // Assert: Check if the result matches the expected value
            Assert.Equal(expectedInches, actualInches);

        }
    }
}
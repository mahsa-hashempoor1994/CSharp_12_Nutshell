

namespace Chapter_2_Language_Basic
{

    public class SwichExpressionTestClass
    {

        [Fact]
        public void SwichExpressionTests()
        {
            // Arrange
            int cardNumber = 13;

            // Act
            string result = cardNumber switch
            {
                13 => "King",
                12 => "Queen",
                11 => "Jack",
                _ => "Pip card"
            };
            

            // Assert
            Assert.Equal("King", result);
          

        }
    }
}
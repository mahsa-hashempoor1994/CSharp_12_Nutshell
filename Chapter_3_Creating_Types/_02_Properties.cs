namespace Chapter_3_Creating_Types
{
    public class Note
    {
        public int Pitch { get; init; }
        public int Duration { get; init; }
    }
    public class PropertiesTestClass
    {

        [Fact]
        public void Test1()
        {
            //Arrange
            Note note = new Note { Pitch=50};

            //Act

            //note.Pitch = 60; // Error – init-only setter!

            //Assert

            Assert.Equal(50, note.Pitch);

        }
    }
}
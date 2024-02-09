namespace Chapter_3_Creating_Types
{
    public class Rectangle
    {
        public readonly float Width, Height;
        public Rectangle(float width, float height)
        {
            Width = width;
            Height = height;
        }
        /// <summary>
        /// deconstructor does the reverse and assigns fields back to a set of variables.
        /// A deconstruction method must be called Deconstruct and must have one or more
        ///out parameters
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void Deconstruct(out float width, out float height)
        {
            width = this.Width;
            height = this.Height;
        }
    }
    public class DeconstructorsTestClass
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var rect = new Rectangle(3, 4);

            //Act

            (float width, float height) = rect;

            //Assert

            Assert.Equal(3, width);
            Assert.Equal(4, height);

        }
    }
}
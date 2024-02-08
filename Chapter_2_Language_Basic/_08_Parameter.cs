
namespace Chapter_2_Language_Basic
{

    public class ParameterTestClass
    {

        [Fact]
        public void PassingArgumentsByValueTests()
        {
            // Arrange
            int x = 8;
            void Foo(int x)
            {
                x = x + 1;

            }


            // Act
            Foo(x);

            // Assert
            Assert.Equal(8, x);

        }

        [Fact]
        public void PassingArgumentsByRefrenceTests()
        {
            // Arrange
            StringBuilder sb = new StringBuilder();
            static void Foo(StringBuilder? fooSB)
            {
                fooSB?.Append("test");
                fooSB = null;
            }


            // Act
            Foo(sb);

            // Assert
            Assert.NotNull(sb);
            Assert.Equal("test", sb.ToString());


        }

        [Fact]
        public void PassingArgumentsByRefTests()
        {
            // Arrange
            int x = 8;
            void Foo(ref int x)
            {
                x = x + 1;

            }


            // Act
            Foo(ref x);

            // Assert
            Assert.Equal(9, x);

        }

        /// <summary>
        /// • It need not be assigned before going into the function.
        ///• It must be assigned before it comes out of the function.
        /// </summary>
        [Fact]
        public void OutParameterTests()
        {
            // Arrange
            string a, b;
            void Split(string name, out string firstNames, out string lastName)
            {
                int i = name.LastIndexOf(' ');
                firstNames = name.Substring(0, i);
                lastName = name.Substring(i + 1);
            }


            // Act
            Split("Stevie Ray Vaughn", out a, out b);

            // Assert
            Assert.Equal("Stevie Ray", a);
            Assert.Equal("Vaughn", b);

        }

        /// <summary>
        /// It allows the  method to accept any number of arguments of a particular type
        /// </summary>
        [Fact]
        public void ParamsModifierTests()
        {
            // Arrange
            int Sum(params int[] ints)
            {
                int sum = 0;
                for (int i = 0; i < ints.Length; i++)
                    sum += ints[i]; // Increase sum by ints[i]
                return sum;
            }


            // Act
            int total = Sum(1, 2, 3, 4);

            // Assert
            Assert.Equal(10, total);


        }

        /// <summary>
        /// Creating a ref local variable that refrences to the element of an Array
        /// </summary>
        [Fact]
        public void RefLocalsTests()
        {
            // Arrange
            int[] numbers = { 1, 4, 5, 4 };
            ref int numRef = ref numbers[2];

            // Act

            numRef++;

            // Assert
            Assert.Equal(6, numbers[2]);


        }
        [Fact]
        public void RefReturnTests()
        {
            // Arrange

            string x = "Old Value";
             ref string GetX(ref string x)
            {
                return ref x;
            }

            // Act

            ref string xRef = ref GetX(ref x);
            xRef = "New Value";

            // Assert
            Assert.Equal("New Value", x);


        }

        
    }
}
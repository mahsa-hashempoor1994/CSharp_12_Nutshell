using System.Security.Cryptography;

namespace Chapter_3_Creating_Types
{
    public partial class MyClass
    {
        public partial string PartialMethod();
        public string Mehod1()
        {
            var result=PartialMethod();
            return "Method1 called from MyClass1.cs" + Environment.NewLine + result  ;
        }

    }

    public partial class MyClass
    {
        public partial string PartialMethod()
        {
            return "Partial method implemented in MyClass2.cs";
        }
        public string Mehod2()
        {
           var result= PartialMethod();
            return "Method2 called from MyClass2.cs" + Environment.NewLine + result;
        }
    }
    public class PartialTestClass
    {
        [Fact]
        public void Test1()
        {
            //Arrange
          var myclass=new MyClass();

            //Act

            var expectedOutput1 = "Method1 called from MyClass1.cs" + Environment.NewLine +
                               "Partial method implemented in MyClass2.cs";

            var expectedOutput2 = "Method1 called from MyClass1.cs" + Environment.NewLine +
                              "Partial method implemented in MyClass2.cs";

            var method1=myclass.Mehod1();
            var method2=myclass.Mehod2();

            //Assert

            Assert.Equal(expectedOutput1, method1);
            Assert.Equal(expectedOutput2, method2);

        }

       

    }
    
}
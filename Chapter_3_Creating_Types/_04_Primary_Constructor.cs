using System.Reflection.Metadata.Ecma335;

namespace Chapter_3_Creating_Types
{

    public class Person(string firstname, string lastName)
    {
        public Person(string firstname, string lastName, int age):this(firstname,lastName)
        {
            
        }
        //field
        public readonly string Firstname = firstname;

        //property
        public string LastName { get; } = lastName;

        public  readonly string Fulltime=firstname+" "+lastName;
    }
    public class PrimaryConstructorTestClass
    {
        [Theory]
        [InlineData("Mahsa","Hashempoor")]
        public void Test1(string firstname, string lastname)
        {
            //Arrange
            Person p = new(firstname, lastname);
            

            //Act
           
            var result=p.Fulltime;
            

            //Assert

            Assert.Equal(firstname+" "+lastname, result);


        }
    }
}
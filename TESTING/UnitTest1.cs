using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Configuration;

namespace TESTING
{
    [TestClass]
    public class UnitTest1
    {
        Form1 myForm = new Form1();

        [TestMethod]
        public void TestConnection()
        {
            var actualDataString = myForm.HostConfigurations();

            var expectedDataString = @"Data Source=PANDEYIAM\SQLEXPRESS01;Initial Catalog=A2;Integrated Security=True";
            Assert.AreEqual(expectedDataString, actualDataString);
        }

        [TestMethod]
        public void Test_Pricing_Calculations()
        {


            // Act
            var jatt = myForm.PriceCalculation(3, 5);

            // Assert
            Assert.AreEqual(expected: 15, actual: jatt);
        }

        [TestMethod]
        public void Rented_Movies()
        {


            // Act
            var actual = myForm.GetUserRentedMovies(0);

            // Assert
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Rented_Movies_Count()
        {

            // Act
            var actual = myForm.GetRentedMoviesCount(0);

            // Assert
            Assert.AreEqual(0, actual);
        }



    }

}
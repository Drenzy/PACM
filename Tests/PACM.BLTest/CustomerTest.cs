using Microsoft.VisualStudio.TestTools.UnitTesting;
using PACM.BL;

namespace PACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            // Using an object initializer to create a Test Customer Object
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };

            // Variable to hold the expected result when actually running the FullName Property
            string expected = "Baggins, Bilbo";

            //-- Act
            // Actually performing the operation we are testing
            string actual = customer.FullName;

            //-- Assert
            // Verifying the expected value equals the actual value
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            // Using an object initializer to create a Test Customer Object
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };

            // Variable to hold the expected result when actually running the FullName Property
            string expected = "Baggins";

            //-- Act
            // Actually performing the operation we are testing
            string actual = customer.FullName;

            //-- Assert
            // Verifying the expected value equals the actual value
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            // Using an object initializer to create a Test Customer Object
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };

            // Variable to hold the expected result when actually running the FullName Property
            string expected = "Bilbo";

            //-- Act
            // Actually performing the operation we are testing
            string actual = customer.FullName;

            //-- Assert
            // Verifying the expected value equals the actual value
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //-- Arrange
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@hobbiton.me"
            };

            var expected = true;

            //-- Act
            var actual = customer.Validate();


            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //-- Arrange
            var customer = new Customer
            {
                EmailAddress = "fbaggins@hobbiton.me"
            };

            var expected = false;

            //-- Act
            var actual = customer.Validate();


            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
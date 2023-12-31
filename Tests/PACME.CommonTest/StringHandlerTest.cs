using Microsoft.VisualStudio.TestTools.UnitTesting;
using PACME.Common;

namespace PACME.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            // -- Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            // -- Act
            // var actual = StringHandler.InsertSpaces(source);
            var actual = source.InsertSpaces();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpacesTestWithExistingSpace()
        {
            // -- Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            // -- Act
            //var actual = StringHandler.InsertSpaces(source);
            var actual = source.InsertSpaces();

            // -- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
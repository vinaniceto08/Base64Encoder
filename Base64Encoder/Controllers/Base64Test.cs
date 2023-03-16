using Base64Encoder.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Base64Encoder.Controllers.Base64EncoderController;

namespace Base64Encoder.Test
{

    [TestClass]
    public class Base64ControllerTests
    {
        [TestMethod]
        public void Encode_ReturnsBase64EncodedString()
        {
            // Arrange
            var controller = new Base64EncoderController();

            // Act
            var result = controller.Encode("hello world");

            // Assert
            Assert.AreEqual("aGVsbG8gd29ybGQ=", result);
        }
    }
}

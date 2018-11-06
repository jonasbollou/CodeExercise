using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPI.Controllers;

namespace WebAPI.Tests.Controllers
{
    [TestClass]
    public class HelloWordControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            helloworldController controller = new helloworldController();

            // Act
            string result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(10, result.Length);
            Assert.AreEqual("Hello Word", result);
        }
    }
}

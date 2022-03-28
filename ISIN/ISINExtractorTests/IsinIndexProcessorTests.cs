using ISINExtractor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ISINExtractorTests
{
    [TestClass]
    public class IsinIndexProcessorTests
    {
        [TestMethod]
        public void ProcessTests_ShouldReturnValidStatus()
        {
            //Arrage
            var returnedPayload = "{}";
            Mock<IApiConnector> apiConnectorMock = new Mock<IApiConnector>();
            apiConnectorMock.Setup(c => c.GetIsinData(It.IsAny<string>())).Returns(returnedPayload);

            //Act
            var processroUnderTest = new IsinIndexProcessor(apiConnectorMock.Object, [...]);

            //Assert

        }
    }
}
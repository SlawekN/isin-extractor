using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ISINExtractor.Tests
{
    [TestClass()]
    public class IsinExtractorTests
    {
        [TestMethod()]
        public void ExtractIsinTest_ShouldExtractTwoISINS()
        {
            IsinExtractor extractor = new IsinExtractor();

            var extractedIsins = extractor.ExtractIsin("FR0014006BL6; SE0017083074").ToList();

            Assert.AreEqual(2, extractedIsins.Count);
            Assert.AreEqual(extractedIsins[0], "FR0014006BL6");
        }
    }
}
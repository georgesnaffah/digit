using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DigitizingSolution.Tests
{
    [TestClass]
    public class CategorizationServiceTests
    {
        [TestMethod]
        public void Categorize_Invoice_ReturnsInvoice()
        {
            var service = new CategorizationService();
            var text = "This is an invoice for a recent purchase.";
            var category = service.Categorize(text);
            Assert.AreEqual("Invoice", category);
        }

        [TestMethod]
        public void Categorize_Contract_ReturnsContract()
        {
            var service = new CategorizationService();
            var text = "This is a contract for the new project.";
            var category = service.Categorize(text);
            Assert.AreEqual("Contract", category);
        }

        [TestMethod]
        public void Categorize_Report_ReturnsReport()
        {
            var service = new CategorizationService();
            var text = "This is a report on the company's performance.";
            var category = service.Categorize(text);
            Assert.AreEqual("Report", category);
        }

        [TestMethod]
        public void Categorize_Uncategorized_ReturnsUncategorized()
        {
            var service = new CategorizationService();
            var text = "This is a random document.";
            var category = service.Categorize(text);
            Assert.AreEqual("Uncategorized", category);
        }
    }
}

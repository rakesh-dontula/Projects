using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldsSmallestBookstore.Models;
namespace WorldsSmallestBookstore.Server.Controllers.Tests
{
    [TestClass()]
    public class CustomerControllerTests
    {
        [TestMethod()]
        public void Customer_GetTest()
        {
            var instance = new CustomerController();
            var result = instance.Get();
            Assert.IsNotNull(result);
            var actualList = result.ToList();

            var testDataContext = new BookstoreEntities();
            SampleData.GenerateSampleData(testDataContext);

            Assert.AreEqual(testDataContext.Customers.Count(), actualList.Count, "Unexpected Number of Customers Returned");
        }
    }
}

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldsSmallestBookstore.Client;

namespace WorldsSmallestBookstore.IntegrationTests
{
    [TestClass]
    public class ServiceClientTests
    {
        [TestMethod]
        public void Books_GetTest()
        {
            var instance = new ServiceClient();
            Assert.IsNotNull(instance, "Failed to get Test Instance");
            var actual = instance.GetBooks();
            Assert.IsNotNull(actual,"Failed to get Enumerable Result");
            var books = actual.ToList();
            Assert.AreEqual(4, books.Count);
        }

        [TestMethod]
        public void Books_GetAuthor()
        {
            var instance = new ServiceClient();
            Assert.IsNotNull(instance, "Failed to get Test Instance");
            var actual = instance.GetAuthors();
            Assert.IsNotNull(actual, "Failed to get Enumerable Result");
            var books = actual.ToList();
            Assert.AreEqual(3, books.Count);
        }

        [TestMethod]
        public void Books_GetPublisher()
        {
            var instance = new ServiceClient();
            Assert.IsNotNull(instance, "Failed to get Test Instance");
            var actual = instance.GetPublishers();
            Assert.IsNotNull(actual, "Failed to get Enumerable Result");
            var books = actual.ToList();
            Assert.AreEqual(2, books.Count);
        }
    }
}

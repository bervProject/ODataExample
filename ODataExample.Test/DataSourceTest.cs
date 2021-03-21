using Microsoft.VisualStudio.TestTools.UnitTesting;
using ODataExample.Utilities;

namespace ODataExample.Test
{
    [TestClass]
    public class DataSourceTest
    {
        [TestMethod]
        public void GetBooks()
        {
            var books = DataSource.GetBooks();
            Assert.AreEqual(books.Count, 2);
        }

        [TestMethod]
        public void GetBooksTest()
        {
            var books = DataSource.GetBooks();
            Assert.AreNotEqual(books.Count, 5);
        }
    }
}

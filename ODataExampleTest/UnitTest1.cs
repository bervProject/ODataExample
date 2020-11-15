using Microsoft.VisualStudio.TestTools.UnitTesting;
using ODataExample.Utilities;

namespace ODataExampleTest
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
    }
}

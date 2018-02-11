using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ocph.DAL.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var db = new OcphDbContext())
            {
                var result = db.apakek.Select();
                Assert.IsNotNull(result);
            }
        }
    }
}

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var res = JenkinsIntegration.Program.Sum(5, 6);
            Assert.AreEqual(res, 11);
        }
    }
}
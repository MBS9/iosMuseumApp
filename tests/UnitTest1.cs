using Xamarin.UITest;

namespace tests
{
    [TestClass]
    public class UnitTest1
    {
        /*
        IApp app = ConfigureApp
            .Android
            .ApkFile("/path/to/android.apk")
            .StartApp();
        */
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }
    }
}
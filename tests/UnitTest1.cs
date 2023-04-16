using Xamarin.UITest;

namespace tests
{
    [TestClass]
    public class UnitTest1
    {
        /*
        IApp app = ConfigureApp
            .Android
            .ApkFile("../bin/Debug/net7.0-android/com.companyname.museumAppBud.apk")
            .StartApp();
        */
        [TestMethod]
        public void TestMethod1()
        {
            IApp app = ConfigureApp
                .Android
                .ApkFile("../bin/Debug/net7.0-android/com.companyname.museumAppBud-Signed.apk")
                .StartApp();
            app.Tap(c => c.Text("National Gallery"));
            app.Tap(c => c.Text("Expand"));
            var restults = app.Query(c => c.Text("National Gallery"));
            Assert.IsTrue(restults.Length > 0);
        }
    }
}
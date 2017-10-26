
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Factory;
using TestStack.White.UIItemEvents;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.Finder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestWPFBtnCalc
{
    [TestClass]
    public class UnitTestBtnCalc
    {
        [TestMethod]
        public void TestMethodPlus()
        {
            Application application = Application.Launch("C:\\my stuff\\ORT courses\\Homeworks\\WpfAppCalcBtn\\WpfAppCalcBtn\\bin\\Release\\WpfAppCalcBtn.exe");
            Window window = application.GetWindow("MainWindow", InitializeOption.NoCache);

            window.Get<Button>("btn8").Click();
            window.Get<Button>("btnPlus").Click();
            window.Get<Button>("btn2").Click();
            window.Get<Button>("btnEquals").Click();
            string res = window.Get<TextBox>("txtField").Text;
            application.Kill();
            Assert.AreEqual("10", res);
        }

        [TestMethod]
        public void TestMethodMinus()
        {
            Application application = Application.Launch("C:\\my stuff\\ORT courses\\Homeworks\\WpfAppCalcBtn\\WpfAppCalcBtn\\bin\\Release\\WpfAppCalcBtn.exe");
            Window window = application.GetWindow("MainWindow", InitializeOption.NoCache);

            window.Get<Button>("btn5").Click();
            window.Get<Button>("btnMinus").Click();
            window.Get<Button>("btn3").Click();
            window.Get<Button>("btnEquals").Click();
            string res = window.Get<TextBox>("txtField").Text;
            application.Kill();
            Assert.AreEqual("2", res);
        }

        [TestMethod]
        public void TestMethodMult()
        {
            Application application = Application.Launch("C:\\my stuff\\ORT courses\\Homeworks\\WpfAppCalcBtn\\WpfAppCalcBtn\\bin\\Release\\WpfAppCalcBtn.exe");
            Window window = application.GetWindow("MainWindow", InitializeOption.NoCache);

            window.Get<Button>("btn5").Click();
            window.Get<Button>("btnMult").Click();
            window.Get<Button>("btn6").Click();
            window.Get<Button>("btnEquals").Click();
            string res = window.Get<TextBox>("txtField").Text;
            application.Kill();
            Assert.AreEqual("30", res);
        }

        [TestMethod]
        public void TestMethodDiv()
        {
            Application application = Application.Launch("C:\\my stuff\\ORT courses\\Homeworks\\WpfAppCalcBtn\\WpfAppCalcBtn\\bin\\Release\\WpfAppCalcBtn.exe");
            Window window = application.GetWindow("MainWindow", InitializeOption.NoCache);

            window.Get<Button>("btn5").Click();
            window.Get<Button>("btnDiv").Click();
            window.Get<Button>("btn1").Click();
            window.Get<Button>("btnEquals").Click();
            string res = window.Get<TextBox>("txtField").Text;
            application.Close();
            Assert.AreEqual("5", res);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

[assembly: Parallelize(Workers = 21, Scope = ExecutionScope.MethodLevel)]
namespace ThreadSafeProject
{
    [TestClass]
    public class UnitTest1
    {

        [TestInitialize]
        public void Setup()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.Manage().Window.Maximize();
            driver.Url= "http://www.csm-testcenter.org/test?do=show&subdo=common&test=file_upload";
            
        }
        [TestMethod]
        public void TestMethod0()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.FindElement(By.CssSelector("input[name='file_upload']")).SendKeys(@"C:\Users\antwan.maddox\source\repos\ThreadSafeProject\ThreadSafeProject\Files\" + "UsingXPath.pdf");
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            bool value = wait.Until(drv => drv.FindElement(By.XPath("//*[text()='File Upload Finished']")).Displayed == true);

            Assert.IsTrue(value);


        }

        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.FindElement(By.CssSelector("input[name='file_upload']")).SendKeys(@"C:\Users\antwan.maddox\source\repos\ThreadSafeProject\ThreadSafeProject\Files\" + "UsingXPath.pdf");
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            bool value = wait.Until(drv => drv.FindElement(By.XPath("//*[text()='File Upload Finished']")).Displayed == true);

            Assert.IsTrue(value);


        }
        [TestMethod]
        public void TestMethod2()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.FindElement(By.CssSelector("input[name='file_upload']")).SendKeys(@"C:\Users\antwan.maddox\source\repos\ThreadSafeProject\ThreadSafeProject\Files\" + "UsingXPath.pdf");
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            bool value = wait.Until(drv => drv.FindElement(By.XPath("//*[text()='File Upload Finished']")).Displayed == true);

            Assert.IsTrue(value);


        }
        [TestMethod]
        public void TestMethod3()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.FindElement(By.CssSelector("input[name='file_upload']")).SendKeys(@"C:\Users\antwan.maddox\source\repos\ThreadSafeProject\ThreadSafeProject\Files\" + "UsingXPath.pdf");
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            bool value = wait.Until(drv => drv.FindElement(By.XPath("//*[text()='File Upload Finished']")).Displayed == true);

            Assert.IsTrue(value);


        }
        [TestMethod]
        public void TestMethod4()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.FindElement(By.CssSelector("input[name='file_upload']")).SendKeys(@"C:\Users\antwan.maddox\source\repos\ThreadSafeProject\ThreadSafeProject\Files\" + "UsingXPath.pdf");
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            bool value = wait.Until(drv => drv.FindElement(By.XPath("//*[text()='File Upload Finished']")).Displayed == true);

            Assert.IsTrue(value);


        }
        [TestMethod]
        public void TestMethod5()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.FindElement(By.CssSelector("input[name='file_upload']")).SendKeys(@"C:\Users\antwan.maddox\source\repos\ThreadSafeProject\ThreadSafeProject\Files\" + "UsingXPath.pdf");
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            bool value = wait.Until(drv => drv.FindElement(By.XPath("//*[text()='File Upload Finished']")).Displayed == true);

            Assert.IsTrue(value);


        }
        [TestMethod]
        public void TestMethod6()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.FindElement(By.CssSelector("input[name='file_upload']")).SendKeys(@"C:\Users\antwan.maddox\source\repos\ThreadSafeProject\ThreadSafeProject\Files\" + "UsingXPath.pdf");
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            bool value = wait.Until(drv => drv.FindElement(By.XPath("//*[text()='File Upload Finished']")).Displayed == true);

            Assert.IsTrue(value);


        }
        [TestMethod]
        public void TestMethod7()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.FindElement(By.CssSelector("input[name='file_upload']")).SendKeys(@"C:\Users\antwan.maddox\source\repos\ThreadSafeProject\ThreadSafeProject\Files\" + "UsingXPath.pdf");
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            bool value = wait.Until(drv => drv.FindElement(By.XPath("//*[text()='File Upload Finished']")).Displayed == true);

            Assert.IsTrue(value);


        }
        [TestMethod]
        public void TestMethod8()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.FindElement(By.CssSelector("input[name='file_upload']")).SendKeys(@"C:\Users\antwan.maddox\source\repos\ThreadSafeProject\ThreadSafeProject\Files\" + "UsingXPath.pdf");
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            bool value = wait.Until(drv => drv.FindElement(By.XPath("//*[text()='File Upload Finished']")).Displayed == true);

            Assert.IsTrue(value);


        }
        [TestMethod]
        public void TestMethod9()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.FindElement(By.CssSelector("input[name='file_upload']")).SendKeys(@"C:\Users\antwan.maddox\source\repos\ThreadSafeProject\ThreadSafeProject\Files\" + "UsingXPath.pdf");
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            bool value = wait.Until(drv => drv.FindElement(By.XPath("//*[text()='File Upload Finished']")).Displayed == true);

            Assert.IsTrue(value);


        }
        [TestMethod]
        public void TestMethod10()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.FindElement(By.CssSelector("input[name='file_upload']")).SendKeys(@"C:\Users\antwan.maddox\source\repos\ThreadSafeProject\ThreadSafeProject\Files\" + "UsingXPath.pdf");
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            bool value = wait.Until(drv => drv.FindElement(By.XPath("//*[text()='File Upload Finished']")).Displayed == true);

            Assert.IsTrue(value);


        }
        [TestMethod]
        public void TestMethod11()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.FindElement(By.CssSelector("input[name='file_upload']")).SendKeys(@"C:\Users\antwan.maddox\source\repos\ThreadSafeProject\ThreadSafeProject\Files\" + "UsingXPath.pdf");
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            bool value = wait.Until(drv => drv.FindElement(By.XPath("//*[text()='File Upload Finished']")).Displayed == true);

            Assert.IsTrue(value);


        }
        [TestMethod]
        public void TestMethod12()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.FindElement(By.CssSelector("input[name='file_upload']")).SendKeys(@"C:\Users\antwan.maddox\source\repos\ThreadSafeProject\ThreadSafeProject\Files\" + "UsingXPath.pdf");
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            bool value = wait.Until(drv => drv.FindElement(By.XPath("//*[text()='File Upload Finished']")).Displayed == true);

            Assert.IsTrue(value);


        }
        [TestMethod]
        public void TestMethod13()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.FindElement(By.CssSelector("input[name='file_upload']")).SendKeys(@"C:\Users\antwan.maddox\source\repos\ThreadSafeProject\ThreadSafeProject\Files\" + "UsingXPath.pdf");
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            bool value = wait.Until(drv => drv.FindElement(By.XPath("//*[text()='File Upload Finished']")).Displayed == true);

            Assert.IsTrue(value);


        }
        [TestMethod]
        public void TestMethod14()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.FindElement(By.CssSelector("input[name='file_upload']")).SendKeys(@"C:\Users\antwan.maddox\source\repos\ThreadSafeProject\ThreadSafeProject\Files\" + "UsingXPath.pdf");
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            bool value = wait.Until(drv => drv.FindElement(By.XPath("//*[text()='File Upload Finished']")).Displayed == true);

            Assert.IsTrue(value);


        }
        [TestMethod]
        public void TestMethod15()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.FindElement(By.CssSelector("input[name='file_upload']")).SendKeys(@"C:\Users\antwan.maddox\source\repos\ThreadSafeProject\ThreadSafeProject\Files\" + "UsingXPath.pdf");
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            bool value = wait.Until(drv => drv.FindElement(By.XPath("//*[text()='File Upload Finished']")).Displayed == true);

            Assert.IsTrue(value);


        }
        [TestMethod]
        public void TestMethod16()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.FindElement(By.CssSelector("input[name='file_upload']")).SendKeys(@"C:\Users\antwan.maddox\source\repos\ThreadSafeProject\ThreadSafeProject\Files\" + "UsingXPath.pdf");
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            bool value = wait.Until(drv => drv.FindElement(By.XPath("//*[text()='File Upload Finished']")).Displayed == true);

            Assert.IsTrue(value);


        }
        [TestMethod]
        public void TestMethod17()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.FindElement(By.CssSelector("input[name='file_upload']")).SendKeys(@"C:\Users\antwan.maddox\source\repos\ThreadSafeProject\ThreadSafeProject\Files\" + "UsingXPath.pdf");
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            bool value = wait.Until(drv => drv.FindElement(By.XPath("//*[text()='File Upload Finished']")).Displayed == true);

            Assert.IsTrue(value);


        }
        [TestMethod]
        public void TestMethod18()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.FindElement(By.CssSelector("input[name='file_upload']")).SendKeys(@"C:\Users\antwan.maddox\source\repos\ThreadSafeProject\ThreadSafeProject\Files\" + "UsingXPath.pdf");
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            bool value = wait.Until(drv => drv.FindElement(By.XPath("//*[text()='File Upload Finished']")).Displayed == true);

            Assert.IsTrue(value);


        }
        [TestMethod]
        public void TestMethod19()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.FindElement(By.CssSelector("input[name='file_upload']")).SendKeys(@"C:\Users\antwan.maddox\source\repos\ThreadSafeProject\ThreadSafeProject\Files\" + "UsingXPath.pdf");
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            bool value = wait.Until(drv => drv.FindElement(By.XPath("//*[text()='File Upload Finished']")).Displayed == true);

            Assert.IsTrue(value);


        }
        [TestMethod]
        public void TestMethod20()
        {
            IWebDriver driver = DriverFactory.getInstance().getDriver();
            driver.FindElement(By.CssSelector("input[name='file_upload']")).SendKeys(@"C:\Users\antwan.maddox\source\repos\ThreadSafeProject\ThreadSafeProject\Files\" + "UsingXPath.pdf");
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);
            bool value = wait.Until(drv => drv.FindElement(By.XPath("//*[text()='File Upload Finished']")).Displayed == true);

            Assert.IsTrue(value);


        }


        [TestCleanup]
        public void Cleanup()
        {
            DriverFactory.getInstance().removeDriver();

        }
    }
}

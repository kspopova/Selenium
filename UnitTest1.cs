using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace SeleniumExercise2
{
    [TestClass]
    public class UnitTest1
    {
        public IWebDriver Driver;
        private object GoToURL;

        [TestInitialize]
        public void OpenBrowser()
        {
            Driver = new ChromeDriver();
        }


        [TestMethod]
        public void TestMethod1()
        {

            Driver.Navigate().GoToUrl("http://store.demoqa.com/products-page/your-account/");
            Driver.FindElement(By.Id("log")).SendKeys("kami_93ss@abv.bg");
            Driver.FindElement(By.Id("pwd")).SendKeys("silistra93");
            Driver.FindElement(By.Id("login")).Click();
            Thread.Sleep(5000);
            var user = Driver.FindElement(By.CssSelector("#wp-admin-bar-my-account > a:nth-child(1)")).Text;
           // Assert.AreNot

                int a = 5;
                int b = 5;
               }


        [TestMethod]
        public void DetailsPage()
        {
            Driver.Navigate().GoToUrl("http://store.demoqa.com/products-page/your-account/");
            Driver.FindElement(By.Id("log")).SendKeys("kami_93ss@abv.bg");
            Driver.FindElement(By.Id("pwd")).SendKeys("silistra93");
            Driver.FindElement(By.Id("login")).Click();
            Thread.Sleep(3000);

            Driver.Navigate().GoToUrl("http://store.demoqa.com/products-page/your-account/?tab=edit_profile");
            string firstName = Faker.Name.First();
            string lastName = Faker.Name.Last();
            string email = Faker.Internet.Email();

            Driver.FindElement(By.Id("wpsc_checkout_form_2")).SendKeys("firstName");
            Driver.FindElement(By.Id("wpsc_checkout_form_3")).SendKeys("lastName");

            Driver.FindElement(By.Id("wpsc_checkout_form_4")).SendKeys("79 Aleksandroska Str");
            Driver.FindElement(By.Id("wpsc_checkout_form_5")).SendKeys("Ruse");
            Driver.FindElement(By.Id("wpsc_checkout_form_6")).SendKeys("Ruse");

            var country = new SelectElement(Driver.FindElement(By.Id("wpsc_checkout_form_7")));
            country.SelectByValue("BG");

            Driver.FindElement(By.Id("wpsc_checkout_form_18")).SendKeys("088349934");
            Driver.FindElement(By.Id("wpsc_checkout_form_9")).SendKeys("email");
            Driver.FindElement(By.Id("wpsc_checkout_form_15")).SendKeys("Ruse");

            Driver.FindElement(By.CssSelector(".myaccount > form:nth-child(2) > table:nth-child(3) > tbody:nth-child(1) > tr:nth-child(1) > td:nth-child(1) > input:nth-child(2)")).Click();



        }


        [TestMethod]
        public void ex2()
        {
            Driver.Navigate().GoToUrl("http://store.demoqa.com/products-page/product-category/");
            var value = Driver.FindElement(By.CssSelector(".count")).Text;
            Driver.FindElement(By.CssSelector("div.default_product_display:nth-child(3) > div:nth-child(2) > form:nth-child(3) > div:nth-child(4) > div:nth-child(1) > span:nth-child(1) > input:nth-child(1)")).Click();
            Thread.Sleep(3000);
            Assert.AreNotEqual("1", value);

        }



        [TestCleanup]
        public void CloseBrowser()
        {
           Driver.Close();
        }

    }
}

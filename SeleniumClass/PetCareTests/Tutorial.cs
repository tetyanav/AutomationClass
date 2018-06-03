using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Shouldly;
using System;

namespace PetCareTests
{
    [TestFixture]
    public class FirstClass
    {
        [Test]
        public void FirstTest()
        {
            var driver = new ChromeDriver(); //declare and initialize variable driver, create an instance of ChromeDriver
            driver.Navigate().GoToUrl("http://www.google.com");//tell to driver to navigate to the target URL(call Navigate() method) 
            var searchBox = driver.FindElement(By.Name("q"));//declare and initilize variable searchBox, that will be the element with a name "q"
            searchBox.SendKeys("Spring" + Keys.Enter);//input value "Spring" in searchBox variable and press Enter key

            driver.Title.ShouldBe("Spring - Google Search", "Page Title");//ask driver to verify that the page title is "Spring - Google Search"
            driver.Quit();//ask driver to close web browser
        }

        [Test]
        public void PageContactTest()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://demoqa.com/contact");
            var yourNameBox = driver.FindElement(By.Name("your - name"));
            yourNameBox.SendKeys("Tanya");
            var yourEmailBox = driver.FindElement(By.Name("your-email"));
            yourEmailBox.SendKeys("Tanya@mail.com");
            var subjectBox = driver.FindElement(By.Name("your-subject"));
            subjectBox.SendKeys("Questions");
            var yourMessageBox = driver.FindElement(By.Name("your-message"));
            yourMessageBox.SendKeys("Bla bla bla" + Keys.Enter);
            //yourMessageBox.SendKeys("Bla bla bla");
            //var sendButton = driver.FindElement(By.XPath("//div[@class='wpcf7']//input[@type='submit']"));
            //sendButton.Click();


        }
        [Test]
        public void ConditionalOperatorsTest()
        {
            bool alreadyLoggedIn = true;
            bool isUsernameEntered = true;
            bool isPasswordEntered = true;
            bool isLoginButtonVisible = true;

            bool result = alreadyLoggedIn || isUsernameEntered && isPasswordEntered && isLoginButtonVisible;
            Console.WriteLine("Result 1:");
            //Console.WriteLine(canLogin);


            isLoginButtonVisible = false;
            result = alreadyLoggedIn || isUsernameEntered && isPasswordEntered && isLoginButtonVisible;
            Console.WriteLine("Result 2:");
            //Console.WriteLine(canLogin);
        }
    }
}

// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class WishListTestTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void wishListTest() {
    driver.Navigate().GoToUrl("https://localhost:7265/");
    driver.Manage().Window.Size = new System.Drawing.Size(1565, 727);
    {
      var element = driver.FindElement(By.Id("logout"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    driver.FindElement(By.LinkText("Store")).Click();
    driver.FindElement(By.LinkText("Details")).Click();
    driver.FindElement(By.LinkText("Add to Wishlist")).Click();
    driver.FindElement(By.LinkText("Store")).Click();
    driver.FindElement(By.LinkText("Details")).Click();
    driver.FindElement(By.LinkText("Add to Wishlist")).Click();
  }
}
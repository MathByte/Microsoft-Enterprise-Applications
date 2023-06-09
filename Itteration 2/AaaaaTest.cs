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
public class AaaaaTest {
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
  public void aaaaa() {
    driver.Navigate().GoToUrl("https://localhost:7265/");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1048);
    driver.FindElement(By.Id("navbarCommunityDropdown")).Click();
    driver.FindElement(By.LinkText("Friends")).Click();
    driver.FindElement(By.LinkText("View Wishlist")).Click();
    driver.FindElement(By.CssSelector("tr:nth-child(2) a:nth-child(2)")).Click();
    driver.FindElement(By.CssSelector("tr:nth-child(3) a:nth-child(2)")).Click();
    driver.FindElement(By.CssSelector("tr:nth-child(4) a:nth-child(2)")).Click();
  }
}

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
public class EcievepromotionTest {
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
  public void ecievepromotion() {
    driver.Navigate().GoToUrl("https://localhost:7265/");
    driver.Manage().Window.Size = new System.Drawing.Size(1565, 727);
    driver.FindElement(By.Id("navbarDropdown")).Click();
    driver.FindElement(By.LinkText("Manage")).Click();
    driver.FindElement(By.Id("Input_ReceivePromotion")).Click();
    driver.FindElement(By.Id("update-profile-button")).Click();
    driver.Close();
  }
}

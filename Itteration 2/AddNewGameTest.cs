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
public class AddNewGameTest {
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
  public void addNewGame() {
    driver.Navigate().GoToUrl("https://localhost:7265/");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1048);
    driver.FindElement(By.Id("login")).Click();
    driver.FindElement(By.Id("Input_Username")).Click();
    driver.FindElement(By.Id("Input_Username")).SendKeys("k");
    driver.FindElement(By.Id("Input_Password")).Click();
    driver.FindElement(By.Id("Input_Password")).SendKeys("Ad123!");
    driver.FindElement(By.Id("login-submit")).Click();
    driver.FindElement(By.LinkText("Admin Panel")).Click();
    driver.FindElement(By.LinkText("Add new Game")).Click();
    driver.FindElement(By.Id("Name")).Click();
    driver.FindElement(By.Id("Name")).SendKeys("Dark Siderss");
    driver.FindElement(By.Id("ReleaseDate")).Click();
    driver.FindElement(By.Id("ReleaseDate")).SendKeys("2000-11-15T14:02");
    driver.FindElement(By.Id("PublisherId")).Click();
    {
      var dropdown = driver.FindElement(By.Id("PublisherId"));
      dropdown.FindElement(By.XPath("//option[. = 'Bandai Namco Entertainment']")).Click();
    }
    driver.FindElement(By.Id("DeveloperId")).Click();
    {
      var dropdown = driver.FindElement(By.Id("DeveloperId"));
      dropdown.FindElement(By.XPath("//option[. = 'Bandai Namco Studios']")).Click();
    }
    driver.FindElement(By.Id("GenreId")).Click();
    {
      var dropdown = driver.FindElement(By.Id("GenreId"));
      dropdown.FindElement(By.XPath("//option[. = 'MMO']")).Click();
    }
    driver.FindElement(By.CssSelector(".btn-primary")).Click();
  }
}

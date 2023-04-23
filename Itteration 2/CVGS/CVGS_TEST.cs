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
public class CVGS_TEST
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver(@"C:/Cdriver/");
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();


        driver.Navigate().GoToUrl("https://localhost:7265/");

        driver.Manage().Window.Size = new System.Drawing.Size(1936, 1048);
        Thread.Sleep(1000);
        driver.FindElement(By.Id("login")).Click();
        Thread.Sleep(500);
        driver.FindElement(By.Id("Input_Username")).Click();
        driver.FindElement(By.Id("Input_Username")).SendKeys("k");
        Thread.Sleep(100);
        driver.FindElement(By.Id("Input_Password")).Click();
        Thread.Sleep(100);
        driver.FindElement(By.Id("Input_Password")).SendKeys("Ad123!");
        Thread.Sleep(100);
        driver.FindElement(By.Id("login-submit")).Click();


    }
    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }



    [Test]
    public void AddToCart()
    {
        driver.FindElement(By.LinkText("Store")).Click();
        driver.FindElement(By.LinkText("Add to Cart")).Click();
        driver.FindElement(By.LinkText("Cart")).Click();
    }





    [Test]
    public void DeleteFromCart()
    {
        driver.FindElement(By.LinkText("Cart")).Click();
        driver.FindElement(By.CssSelector("tr:nth-child(2) a")).Click();

    }







        [Test]
    public void AddNewGameTest()
    {

        driver.FindElement(By.Id("navbarDropdown")).Click();
        driver.FindElement(By.LinkText("Admin Panel")).Click();
        Thread.Sleep(1000);
        driver.FindElement(By.LinkText("Add new Game")).Click();
        Thread.Sleep(1000);
        driver.FindElement(By.Id("Name")).Click();
        Thread.Sleep(1000);
        driver.FindElement(By.Id("Name")).SendKeys("Dark Siderss");
     
        driver.FindElement(By.Id("ReleaseDate")).Click();
        driver.FindElement(By.Id("ReleaseDate")).SendKeys("2012-05-12T12:00");
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
            dropdown.FindElement(By.XPath("//option[. = 'RPG']")).Click();
        }
        Thread.Sleep(1000);
        driver.FindElement(By.CssSelector(".btn-primary")).Click();
    }





    [Test]
    public void DeleteGame()
    {
        driver.FindElement(By.Id("navbarDropdown")).Click();
        driver.FindElement(By.LinkText("Admin Panel")).Click();
        driver.FindElement(By.LinkText("Delete")).Click();
        driver.FindElement(By.CssSelector(".btn-danger")).Click();
   

        Thread.Sleep(1000);

    }

   




    [Test]
    public void FavoritesTest()
    {
        driver.FindElement(By.Id("navbarDropdown")).Click();
        driver.FindElement(By.LinkText("Manage")).Click();
        driver.FindElement(By.Id("Input_FavouriteGenre")).Click();
        {
            var dropdown = driver.FindElement(By.Id("Input_FavouriteGenre"));
            dropdown.FindElement(By.XPath("//option[. = 'Puzzle']")).Click();
        }
        driver.FindElement(By.Id("update-profile-button")).Click();
        Thread.Sleep(1000);
        Assert.That(driver.FindElement(By.XPath("/html/body/div/main/div/div/div[2]/div[1]")).Displayed);
    }

    [Test]
    public void SearchTest()
    {
   
        driver.FindElement(By.LinkText("Store")).Click();
        driver.FindElement(By.Name("searchQuery")).SendKeys("dark");
        driver.FindElement(By.CssSelector(".btn-primary")).Click();
        Thread.Sleep(200);
        driver.FindElement(By.LinkText("Details")).Click();



    }



    [Test]
    public void PasswordChangeTest()
    {

        driver.FindElement(By.Id("navbarDropdown")).Click();
        driver.FindElement(By.LinkText("Manage")).Click();
        driver.FindElement(By.Id("change-password")).Click();
        driver.FindElement(By.Id("Input_OldPassword")).Click();
        driver.FindElement(By.Id("Input_OldPassword")).SendKeys("Ad123!");
        driver.FindElement(By.Id("Input_NewPassword")).Click();
        driver.FindElement(By.Id("Input_NewPassword")).SendKeys("Ad123!");
        driver.FindElement(By.Id("Input_ConfirmPassword")).Click();
        driver.FindElement(By.Id("Input_ConfirmPassword")).SendKeys("Ad123!");
        driver.FindElement(By.CssSelector(".w-100")).Click();


      


    }

    [Test]
    public void AddEventTest()
    {
        driver.FindElement(By.Id("navbarDropdown")).Click();
        driver.FindElement(By.LinkText("Admin Panel")).Click();
        driver.FindElement(By.LinkText("Add new Event")).Click();
        driver.FindElement(By.Id("Name")).Click();
        driver.FindElement(By.Id("Name")).SendKeys("evetExample");
        driver.FindElement(By.Id("Description")).Click();
        driver.FindElement(By.Id("Description")).SendKeys("Hello example description");
        driver.FindElement(By.Id("ScheduledTime")).Click();
        driver.FindElement(By.Id("ScheduledTime")).SendKeys("2000-11-11T13:55");
        driver.FindElement(By.CssSelector(".btn-primary")).Click();


    }





    [Test]
    public void LikeAgameTest()
    {


        driver.FindElement(By.LinkText("Store")).Click();
        driver.FindElement(By.LinkText("Details")).Click();
        driver.FindElement(By.LinkText("Like Game")).Click();
        driver.FindElement(By.LinkText("Details")).Click();
        Thread.Sleep(2000);

    }


    [Test]
    public void AddReviewTest()
    {


        driver.FindElement(By.LinkText("Store")).Click();
        driver.FindElement(By.CssSelector("html")).Click();
        driver.FindElement(By.LinkText("Details")).Click();
        driver.FindElement(By.LinkText("Add Review")).Click();
        driver.FindElement(By.Id("Description")).Click();
        driver.FindElement(By.Id("Description")).SendKeys("First Review");
        driver.FindElement(By.CssSelector(".btn-primary")).Click();

    }



    [Test]
    public void AproveReviewTest()
    {
        driver.FindElement(By.Id("navbarDropdown")).Click();
        driver.FindElement(By.LinkText("Admin Panel")).Click();
        driver.FindElement(By.LinkText("Approve")).Click();
        driver.FindElement(By.LinkText("Store")).Click();
        driver.FindElement(By.LinkText("Details")).Click();

    }



    [Test]
    public void EmailChangeTest()
    {
        driver.FindElement(By.Id("navbarDropdown")).Click();
        driver.FindElement(By.LinkText("Manage")).Click();
        driver.FindElement(By.Id("email")).Click();
        driver.FindElement(By.Id("Input_NewEmail")).Click();
        driver.FindElement(By.Id("Input_NewEmail")).Clear();
        driver.FindElement(By.Id("Input_NewEmail")).SendKeys("ad@asd.comasd");
        driver.FindElement(By.Id("change-email-button")).Click();

    }



}

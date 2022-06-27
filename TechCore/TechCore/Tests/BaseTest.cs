using NUnit.Framework;
using OpenQA.Selenium;
using TechCore.Services;

namespace TechCore.Tests;

public class BaseTest
{
    protected IWebDriver? Driver;
    
    [OneTimeSetUp]
    protected void OneTimeSetup()
    {
        Driver = new BrowserService().Driver;
    }

    [OneTimeTearDown]
    protected void OneTimeTearDown()
    {
        Driver!.Quit();
    }
}

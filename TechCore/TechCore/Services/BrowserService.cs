using System;
using OpenQA.Selenium;

namespace TechCore.Services;

public class BrowserService
{
    public BrowserService()
    {
        Driver = Configurator.BrowserType.ToLower() switch
        {
            "chrome" => new DriverFactory().GetChromeDriver(),
            _ => Driver
        };

        Driver.Manage().Window.Maximize();
        Driver.Manage().Cookies.DeleteAllCookies();
        Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(0);
    }

    public IWebDriver? Driver { get; }
}

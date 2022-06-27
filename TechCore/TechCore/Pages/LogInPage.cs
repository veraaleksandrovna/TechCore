using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using TechCore.Services;

namespace TechCore.Pages;

public class LogInPage:BasePage
{
    private static readonly string path = "signin";
 
    public readonly string Email = "dropxx24@mail.ru";
    public readonly string Password = "Deeee!!3929";
    
    private static readonly By EmailFieldBy = By.Id("signIn_Username") ;
    private static readonly By PassworFielddBy = By.Id("signIn_Password");
    private static readonly By ButtonBy = By.ClassName("CPH3F85q485sVMG_u5kc");
    
    public LogInPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }
    
    public IWebElement EmailField => WaitService.WaitElementExist(EmailFieldBy);
    public IWebElement PasswordField => WaitService.WaitElementExist(PassworFielddBy);
    public IWebElement Button => WaitService.WaitElementExist(ButtonBy);
    protected override void OpenPage()
    {
        Driver.Navigate().GoToUrl(Configurator.BaseUrl + path);
    }

    public override bool IsPageOpened()
    {
        try
        {
            return Button.Displayed;
        }
        catch (NoSuchElementException)
        {
            return false;
        }
    }

    public LogInPage EmailKeys()
    {
        EmailField.SendKeys(Email);
        return this;
    }

    public LogInPage PasswordKeys()
    {
        PasswordField.SendKeys(Password);
        return this;
    }

    public LogInPage ButtonClick()
    {
        Button.Click();
        return this;
    }
}

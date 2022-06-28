using OpenQA.Selenium;
using TechCore.Pages;
using TechCore.Services;

namespace TechCore.Pages;

public class CvBuilderPage : BasePage
{
    private static readonly string path = "cvbuilder";

    private static readonly By AddCVButtonBy = By.ClassName("wiMrZiZ5i1gz_G45SGl4");
    private static readonly By NewCvCardBy = By.ClassName("container_card");
    
    public CvBuilderPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

    public IWebElement AddCVButton => WaitService.WaitElementExist(AddCVButtonBy);
    public IWebElement NewCvCard => WaitService.WaitElementExist(NewCvCardBy);
    
    protected override void OpenPage()
    { 
        Driver.Navigate().GoToUrl(Configurator.BaseUrl + path);
    }

    public override bool IsPageOpened()
    {
        try
        {
            return AddCVButton.Displayed;
        }
        catch (NoSuchElementException)
        {
            return false;
        }
    }

    public CvBuilderPage AddCVButtonClick()
    {
        AddCVButton.Click();
        return this;
    }

    public CvBuilderPage NewCVCreated()
    {
        return this;
    }
}

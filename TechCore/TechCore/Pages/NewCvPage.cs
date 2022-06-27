using System.Configuration;
using OpenQA.Selenium;
using TechCore.Services;

namespace TechCore.Pages;

public class NewCvPage: BasePage
{

    public static readonly string FirstName = "Vera";
    public static readonly string LastName = "Vasyukevich";
    public static readonly string CurrentPosition = "QA Engineer";
    public static readonly string AboutMe = "djfhf fubvjsfivj vhusv wviv bvvb vfbijv vbsdv bhsdvb bivsfdvbb vubfv";

    public static readonly string path = "cvbuilder/newcv";

    public static readonly By FirstNameFieldBy = By.Id("personalInfo_firstName");
    public static readonly By LastNameFieldBy = By.Id("personalInfo_lastName");
    public static readonly By CurrentPositionFieldBy = By.Id("personalInfo_professionalTitle");
    public static readonly By AboutMeFieldBy = By.Id("personalInfo_aboutUser");
    public static readonly By NextButtonBy = By.Id("buttonNext");
    public static readonly By SkillsSelectBy = By.ClassName("ant-select-selection-overflow-item-suffix");
    public static readonly By SkillMatrixSkillBy = By.Id("skillForm_skill");
    

    public NewCvPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
        
    }

        public IWebElement FirstNameField => WaitService.WaitElementExist(FirstNameFieldBy);
        public IWebElement LastNameField => WaitService.WaitElementExist(LastNameFieldBy);
        public IWebElement CurrentPositionField => WaitService.WaitElementExist(CurrentPositionFieldBy);
        public IWebElement AboutMeField => WaitService.WaitElementExist(AboutMeFieldBy);
        public IWebElement NextButton => WaitService.WaitElementExist(NextButtonBy);
        
        
    protected override void OpenPage()
    {
        Driver.Navigate().GoToUrl(Configurator.BaseUrl + path);
    }

    public override bool IsPageOpened()
    {
        try
        {
            return NextButton.Displayed;
        }
        catch (NoSuchElementException)
        {
            return false;
        }
    }

    public NewCvPage FirstNameKeys()
    {
       FirstNameField.SendKeys(FirstName);
       return this;
    }

    public NewCvPage LastNameKeys()
    {
        LastNameField.SendKeys(LastName);
        return this;
    }

    public NewCvPage CurrentPositionKeys()
    {
        CurrentPositionField.SendKeys(CurrentPosition);
        return this;
    }

    public NewCvPage AboutMeKeys()
    {
        AboutMeField.SendKeys(AboutMe);
        return this;
    }

    public NewCvPage NextButtonClick()
    {
        NextButton.Click();
        return this;
    }
}

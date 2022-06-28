using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
    //-------------------------------------------------------------------------------------------------------------
    public static readonly By SkillsSelectBy = By.ClassName("ant-select-selection-overflow-item-suffix");
    public static readonly By SkillMatrixSkillBy = By.Id("skillForm_skill");
    public static readonly By YearsBy = By.Id("rc_select_5");
    public static readonly By LevelBy = By.Id("rc_select_6");
    public static readonly By LastUsedBy = By.Id("rc_select_7");

    public NewCvPage(IWebDriver? driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
        
    }

        public static IWebElement FirstNameField => WaitService.WaitElementExist(FirstNameFieldBy);
        public static IWebElement LastNameField => WaitService.WaitElementExist(LastNameFieldBy);
        public static IWebElement CurrentPositionField => WaitService.WaitElementExist(CurrentPositionFieldBy);
        private static IWebElement AboutMeField => WaitService.WaitElementExist(AboutMeFieldBy);
        public static IWebElement NextButton => WaitService.WaitElementExist(NextButtonBy);

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

    public void NextButtonClick()
    {
        NextButton.Click();
    }

   
    
}

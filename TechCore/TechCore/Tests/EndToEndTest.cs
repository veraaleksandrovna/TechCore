using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechCore.Pages;

namespace TechCore.Tests;

[TestFixture]
public class EndToEndTest: BaseTest
{

    [Test]
    public void FullTest()
    {
        var loginPage = new LogInPage(Driver, true);
        loginPage
            .EmailKeys()
            .PasswordKeys()
            .ButtonClick();

        var cvBuilderPage = new CvBuilderPage(Driver, false);
        cvBuilderPage.AddCVButtonClick();
        cvBuilderPage.IsPageOpened();
        
        var newCvPage = new NewCvPage(Driver, false);
        newCvPage.IsPageOpened();

        newCvPage
            .LastNameKeys()
            .FirstNameKeys()
            .CurrentPositionKeys()
            .AboutMeKeys()
            .NextButtonClick();
        
        Driver.Navigate().GoToUrl("https://personal.techcore.io/cvbuilder");
        var displayes = cvBuilderPage.NewCvCard.Displayed;
        Assert.IsTrue(displayes);
    }
    
}

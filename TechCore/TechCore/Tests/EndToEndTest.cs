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

        var newCvPage = new NewCvPage(Driver, false);

        newCvPage
            .FirstNameKeys()
            .LastNameKeys()
            .CurrentPositionKeys()
            .AboutMeKeys()
            .NextButtonClick();
        
    }
    
}

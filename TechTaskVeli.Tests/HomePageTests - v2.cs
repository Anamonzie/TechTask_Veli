using TechTaskVeli;
using Allure.NUnit.Attributes;
using Allure.NUnit;

namespace PlaywrightTests;

[AllureNUnit]
public class HomePageTestsV2 : PageTest
{
    private HomePage homepage;

    [SetUp]
    public void SetUp()
    {
        homepage = new HomePage(Page);
    }

    [Test]
    [AllureName("HasTitle")]
    public async Task HasTitle()
    {
        await homepage.GoToHomePageAsync();

        await Expect(Page).ToHaveTitleAsync(new Regex("Veli Store"));
    }

    [Test]
    [AllureName("GetStartedLink")]
    public async Task GetStartedLink()
    {
        await homepage.GoToHomePageAsync();
        await homepage.ClickBackToSchoolLinkAsync();

        await Task.Delay(1000);

        await Expect(Page).ToHaveURLAsync(new Regex(".*back-to-school.*"));
    }
}
